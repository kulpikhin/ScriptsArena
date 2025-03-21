using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public SubClass characterSubClass;
    public bool isDead { get; private set; }
    public Health HealthCharacter {get; private set;}
    public Mana ManaCharacter {get; private set;}
    public SpeedManager speedManager { get; private set;}

    private int armor;
    private float damagePercentage;
    private float dodgeChance;
    private float critChance;
    private float critDamage;
    private float vampirism;
    private float ccResistance;
    private float abilityCooldown;
    private float speed;
    private float healthRegen;
    private float manaRegen;
    private float healingPower;
    private int petHealth;
    private float petDamage;
    private CharacterAbilities characterAbilities;

    private void OnEnable()
    {
        InitializeCharacterAttributes();
        HealthCharacter.HealthChanged += CheckDeath;
    }

    private void OnDisable()
    {
        HealthCharacter.HealthChanged -= CheckDeath;
    }

    private void InitializeCharacterAttributes()
    {
        if (characterSubClass != null && characterSubClass.baseClass != null)
        {
            HealthCharacter = GetComponent<Health>();
            ManaCharacter = GetComponent<Mana>();
            HealthCharacter.SetMaxHealth(characterSubClass.baseClass.health);
            ManaCharacter.SetMaxMana(characterSubClass.baseClass.mana);
            damagePercentage = characterSubClass.baseClass.damagePercentage;
            armor = characterSubClass.baseClass.armor;
            dodgeChance = characterSubClass.baseClass.dodgeChance;
            critChance = characterSubClass.baseClass.critChance;
            critDamage = characterSubClass.baseClass.critDamage;
            vampirism = characterSubClass.baseClass.vampirism;
            ccResistance = characterSubClass.baseClass.ccResistance;
            abilityCooldown = characterSubClass.baseClass.abilityCooldown;
            speed = characterSubClass.baseClass.speed;
            healthRegen = characterSubClass.baseClass.healthRegen;
            manaRegen = characterSubClass.baseClass.manaRegen;
            healingPower = characterSubClass.baseClass.healingPower;
            petHealth = characterSubClass.baseClass.petHealth;
            petDamage = characterSubClass.baseClass.petDamage;
        }
        else
        {
            Debug.LogError("Character SubClass or BaseClass is not assigned.");
        }
    }

    private void CheckDeath(int health)
    {
        if (health <= 0)
        {
            isDead = true;
        }
    }
}
