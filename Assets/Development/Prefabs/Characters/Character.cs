using Cinemachine;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;

[RequireComponent(typeof(Brain))]
[RequireComponent(typeof(Movement))]
[RequireComponent(typeof(Interactor))]
[RequireComponent(typeof(PlayerAttack))]
public class Character : MonoBehaviour, IDamageable
{
    // Character Parts
    public Transform body;
    public Transform pivot;
    public Animator animator;
    public Transform weaponHand;
    public Transform moveReticle;
    public HealthbarUI healthBarUI;
    public CinemachineVirtualCamera virtualCamera;
    [HideInInspector] public Brain brain;
    [HideInInspector] public Movement movement;
    [HideInInspector] public Interactor interactor;
    [HideInInspector] public PlayerAttack attacker;
    [HideInInspector] public float baseOffset;

    // Castables
    public Loadout loadout;
    public ICastable primaryCastable;
    public ICastable secondaryCastable;
    public Ability ability;
    public Weapon weapon;
    public Vector3 weaponOffset = Vector3.up;
    private int abilityIdx = -1;
    private int weaponIdx = -1;

    // Statuses
    public List<Status> statuses;

    // Health
    public Modified<float> maxHealth = new(25f);
    public Modified<float> currentHealth = new(25f);
    public float MaxHealth { get { return maxHealth.Value; } set { maxHealth.Value = value; } }
    public float CurrentHealth { get { return currentHealth.Value; } set { currentHealth.Value = value; } }
    public UnityEvent onDeath;

    // State
    public bool controllable = true;

    // Initialization
    private void Awake()
    {
        Awarn.IsNotNull(body, "Character has no Body");
        InitBody();
        brain = GetComponent<Brain>();
        movement = GetComponent<Movement>();
        interactor = GetComponent<Interactor>();
        attacker = GetComponent<PlayerAttack>();
        SetControllable(false);
    }

    private void Start()
    {
        InitializeCastables();
        UpdateHealthUI();
    }

    private void InitBody()
    {
        if (body != null)
        {
            CapsuleCollider capsuleCollider= body.GetComponent<CapsuleCollider>();
            baseOffset = capsuleCollider.height / 2;
            capsuleCollider.center = new Vector3(capsuleCollider.center.x, baseOffset, capsuleCollider.center.z);
        }
    }

    // Updates

    private void Update()
    {
        StatusTick();
    }


    // Statuses

    private void StatusTick()
    {
        foreach (Status status in statuses)
        {
            status.effect.Tick(status.strength, this);
        }
    }


    // Aiming

    public void OnCastVectorChanged()
    {
        moveReticle.SetRotationWithVector(movement.castVector);
    }


    // State

    public void SetControllable(bool _controllable)
    {
        brain.Enabled = !_controllable;
        controllable = _controllable;
        movement.canMove = controllable;
        attacker.active = controllable;
        SetComponentActive(moveReticle, _controllable);
        SetComponentActive(virtualCamera, _controllable);
    }

    public void SetComponentActive(Component component, bool _active)
    {
        if (component != null)
        {
            component.gameObject.SetActive(_active);
        }
    }


    // Health

    public void UpdateHealthUI()
    {
        if (healthBarUI != null)
        {
            healthBarUI.UpdateFill(CurrentHealth, MaxHealth);
        }
    }

    public void TakeDamage(float damageAmount)
    {
        CurrentHealth -= damageAmount;
        UpdateHealthUI();
        if (CurrentHealth <= 0f)
        {
            Die();
        }
    }

    public void Die()
    {
        onDeath.Invoke();
        Destroy(gameObject);
    }


    // Castables

    public void InitializeCastables()
    {
        if (loadout != null)
        {
            if (ability == null)
            {
                ChangeAbility();
            }
            if (weapon == null)
            {
                ChangeWeapon();
            }
        }
    }

    public void ChangeCastable(bool primary)
    {
        ICastable castable = primary ? weapon as ICastable : ability as ICastable;
        if (castable != null)
        {
            castable.UnEquip();
        }

        if (loadout != null)
        {
            if (primary)
            {
                if (loadout.weapons.Count > 0)
                {
                    weaponIdx = (weaponIdx + 1) % loadout.weapons.Count;
                    weapon = Instantiate(loadout.weapons[weaponIdx], transform);
                    weapon.Initialize(this);
                }
            }
            else
            {
                if (loadout.abilities.Count > 0)
                {
                    abilityIdx = (abilityIdx + 1) % loadout.abilities.Count;
                    ability = Instantiate(loadout.abilities[abilityIdx], transform);
                    ability.Initialize(this);
                }
            }
        }
    }

    public void ActivateCastable(ICastable castable)
    {
        if (attacker != null && attacker.active)
        {
            attacker.Castable = castable;
            attacker.Slashie(movement.castVector);
        }
    }


    // Actions
    public void MoveCharacter(Vector2 input) { movement.SetMoveVector(input); }
    public void AimCharacter(Vector2 input) { movement.SetAimVector(input); }
    public void ChangeAbility() { ChangeCastable(false); }
    public void ChangeWeapon() { ChangeCastable(true); }
    public void ActivateWeapon() { ActivateCastable(weapon); }
    public void ActivateAbility() { ActivateCastable(ability); }
    public void Interact() { interactor.Talk(); }


    // Debugging

    public void PrintAbilities(List<Ability> abilities)
    {
        string toPrint = "";
        foreach (Ability _ability in abilities)
        {
            toPrint += _ability.gameObject.name + "\n";
        }
        print(toPrint);
    }

    public void PrintWeapons(List<Weapon> weapons)
    {
        string toPrint = "";
        foreach (Weapon _weapon in weapons)
        {
            toPrint += _weapon.gameObject.name + "\n";
        }
        print(toPrint);
    }
}
