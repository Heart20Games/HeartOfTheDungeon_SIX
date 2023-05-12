using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using ScriptableObjectDropdown;

namespace Body.Behavior.ContextSteering
{
    using static CSContext;
    using static CSMapping;
    using static CSIdentity;

    [RequireComponent(typeof(Rigidbody))]
    public class CSController : MonoBehaviour
    {
        // Presets
        [ScriptableObjectDropdown(typeof(CSPreset), grouping = ScriptableObjectGrouping.ByFolderFlat)]
        public ScriptableObjectReference preset;
        public CSPreset Preset { get { return (CSPreset)preset.value; } set { preset.value = value; } }

        public float Speed => Preset.testSpeed;
        public float DrawScale => Preset.drawScale;
        public bool DrawRays => Preset.draw;
        public Contexts Contexts { get => Preset.Contexts; }
        public Identity Identity { get => Preset.Identity; }
        public IdentityMapPair[] Pairs { get => Preset.Pairs; }

        // Initialization
        private new Rigidbody rigidbody;
        private bool initialized = false;

        // Active
        [SerializeField] private bool active = false;
        public bool Active { get => active; set => SetActive(value); }

        // Destination
        [SerializeField] private Vector3 destination = new();
        public bool following = false;
        public Vector3 Destination { get => destination; set { destination = value; following = true; } }

        // Generated
        private readonly Dictionary<Identity, MapType> identityMap = new();
        private readonly List<Transform> obstacles = new();
        private Maps Maps { get; } = new(null, null);

        // Initialize

        private void Awake()
        {
            rigidbody = GetComponent<Rigidbody>();
            Active = Active;
            Initialize();
        }

        public void Initialize()
        {
            if (!initialized)
            {
                initialized = true;

                // Identity Map
                foreach (var pair in Pairs)
                {
                    identityMap[pair.identity] = pair.mapType;
                }
            }
        }

        // Activate

        public void SetActive(bool active)
        {
            this.active = active;
            if (!active && rigidbody != null)
            {
                rigidbody.velocity = Vector3.zero;
            }
        }

        // Update

        private void FixedUpdate()
        {
            if (active)
            {
                MapTo(transform.position - destination, ContextType.Target, Maps.interests);
                Draw();
                rigidbody.velocity = Speed * Time.fixedDeltaTime * GetVector();
            }
        }

        // Get
        public Vector3 GetVector()
        {
            Vector3 vector = new();
            Map interests = Maps[MapType.Interest];
            Map dangers = Maps[MapType.Danger];
            for (int i = 0; i < resolution; i++)
            {
                vector += interests[i] * interests.sign * Baseline[i];
                vector += dangers[i] * dangers.sign * Baseline[i];
                interests[i] = 0f;
                dangers[i] = 0f;
            }
            return vector.normalized;
        }

        public Map GetMapOf(Identity id)
        {
            return Maps[identityMap[id]];
        }

        // Set
        public void MapTo(Vector2 vector, ContextType contextType, Map map)
        {
            if (vector != Vector2.zero)
            {
                // Map / Context
                Context context = Contexts.GetContext(contextType);

                if (vector.magnitude < context.cullDistance)
                {
                    // Weight
                    float distance = vector.magnitude - context.minDistance;
                    float range = (context.maxDistance - context.minDistance);
                    float weight = Mathf.Lerp(context.weight, 0f, distance / range);

                    if (weight > 0f)
                    {
                        // Angle / Slot
                        float angle = vector.x != 0f ? Mathf.Rad2Deg * Mathf.Atan(vector.y / vector.x) : Mathf.Sign(vector.y) * 90;
                        angle = Mathf.Repeat(angle, 360);
                        float slot = Mathf.Repeat((angle / 360) * resolution, 11);

                        Assert.IsFalse(float.IsNaN(angle));
                        Assert.IsFalse(float.IsNaN(slot));
                        AssertInRange(angle, 0, 360);
                        AssertInRange(slot, 0, 11);

                        // Falloff
                        float falloff = (context.falloff / 360) * resolution;
                        float falloffHigh = Mathf.Repeat(slot + falloff, 11);
                        float falloffLow = Mathf.Repeat(slot - falloff, 11);

                        // Slots
                        int nextSlot = Mathf.CeilToInt(slot);
                        int prevSlot = Mathf.FloorToInt(slot);
                        int highSlot = Mathf.FloorToInt(falloffHigh);
                        int lowSlot = Mathf.CeilToInt(falloffLow);

                        AssertInRange(nextSlot, 0, 11);
                        AssertInRange(prevSlot, 0, 11);
                        AssertInRange(highSlot, 0, 11);
                        AssertInRange(lowSlot, 0, 11);

                        //print(nextSlot + " -> " + highSlot + " / " + prevSlot + " -> " + lowSlot);

                        // Add it up
                        for (int i = nextSlot; i <= highSlot; i++)
                        {
                            map[i] += Mathf.Lerp(weight, 0, (i - slot) / falloff);
                        }
                        for (int i = prevSlot; i >= lowSlot; i--)
                        {
                            map[i] += Mathf.Lerp(weight, 0, (slot - i) / falloff);
                        }
                    }
                }
            }
        }

        private void AssertInRange(float value, float min, float max)
        {
            Assert.IsTrue(value >= min);
            Assert.IsTrue(value <= max);
        }

        // Obstacles
        public void AddObstacle(Impact impact)
        {
            if (!impact.other.TryGetComponent<CSController>(out _))
            {
                if (!obstacles.Contains(impact.other.transform))
                {
                    Transform other = impact.other.transform;
                    obstacles.Add(other);
                    Vector2 otherPos = new(other.position.x, other.position.z);
                    Vector2 curPos = new(transform.position.x, transform.position.z);
                    MapTo(otherPos - curPos, ContextType.Obstacle, Maps.dangers);
                }
            }
        }

        public void RemoveObstacle(Impact impact)
        {
            if (!impact.other.TryGetComponent<CSController>(out _))
            {
                obstacles.Remove(impact.other.transform);
            }
        }

        // Draw
        public void Draw()
        {
            if (DrawRays)
            {
                for (int i = 0; i < Maps.Length; i++)
                {
                    Map map = Maps[i];
                    if (!map.IsZero())
                    {
                        print((map.sign < 0 ? "Danger" : "Interest"));
                        for (int j = 0; j < resolution; j++)
                        {
                            if (map[j] > 0)
                            {
                                Color color = map.sign < 0 ? Color.red : Color.green;
                                Vector3 dir = DrawScale * 2 * map.sign * map[j] * Baseline[j];
                                //print("Drawing... " + dir + " (" + DrawScale + "/" + map.sign + "/" + map[j] + "/" + Baseline[j] + ")");
                                Debug.DrawRay(transform.position, dir, color, Time.fixedDeltaTime * 2);
                            }
                        }
                    }
                }
            }
        }
    }
}
