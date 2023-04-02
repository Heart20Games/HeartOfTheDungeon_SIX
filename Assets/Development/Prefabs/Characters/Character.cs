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
    public Health healthBar;
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
    public Castable primary;
    public Castable secondary;
    public Vector3 weaponOffset = Vector3.up;
    private int abilityIdx = -1;
    private int weaponIdx = -1;
    public enum CastSlot { PRIMARY, SECONDARY };

    // Statuses
    public List<Status> statuses;

    // Health
    public Modified<int> maxHealth = new(25);
    public Modified<int> currentHealth = new(25);
    public int MaxHealth { get { return maxHealth.Value; } set { maxHealth.Value = value; } }
    public int CurrentHealth { get { return currentHealth.Value; } set { currentHealth.Value = value; } }
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
        healthBar.SetHealthBase(CurrentHealth, MaxHealth);
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

    //public void UpdateHealthUI()
    //{
    //    if (healthBar != null)
    //    {
    //        healthBar.SetHealth(CurrentHealth);
    //    }
    //}

    public void TakeDamage(int damageAmount)
    {
        CurrentHealth -= damageAmount;
        healthBar.SetHealth(CurrentHealth);
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
            if (secondary == null)
            {
                ChangeCastable(CastSlot.SECONDARY);
            }
            if (primary == null)
            {
                ChangeCastable(CastSlot.PRIMARY);
            }
        }
    }

    public void ChangeCastable(CastSlot slot)
    {
        ICastable castable = slot == CastSlot.PRIMARY ? primary as ICastable : secondary as ICastable;
        if (castable != null)
        {
            castable.UnEquip();
        }

        print("Change Castable: " + slot);

        if (loadout != null)
        {
            switch (slot)
            {
                case CastSlot.PRIMARY:
                    if (loadout.weapons.Count > 0)
                    {
                        weaponIdx = (weaponIdx + 1) % loadout.weapons.Count;
                        primary = Instantiate(loadout.weapons[weaponIdx], transform);
                        primary.Initialize(this);
                    }
                    break;
                case CastSlot.SECONDARY:
                    if (loadout.abilities.Count > 0)
                    {
                        abilityIdx = (abilityIdx + 1) % loadout.abilities.Count;
                        secondary = Instantiate(loadout.abilities[abilityIdx], transform);
                        secondary.Initialize(this);
                    }
                    break;
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
    public void ChangeAbility() { ChangeCastable(CastSlot.SECONDARY); }
    public void ChangeWeapon() { ChangeCastable(CastSlot.PRIMARY); }
    public void ActivateWeapon() { ActivateCastable(primary); }
    public void ActivateAbility() { ActivateCastable(secondary); }
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
