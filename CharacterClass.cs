using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterClass", menuName = "Characters/CharacterClass")]
public class CharacterClass : ScriptableObject
{
    public string className;
    public float damagePercentage;  // Урон (в процентах)
    public int armor;               // Броня
    public int health;              // Здоровье
    public int mana;                // Мана
    public float dodgeChance;       // Шанс уклонения
    public float critChance;        // Шанс крита
    public float critDamage;        // Крит урон
    public float vampirism;         // Вампиризм
    public float ccResistance;      // Сопротивление контролю
    public float abilityCooldown;   // Скорость восстановления способностей
    public float speed;             // Скорость (атаки и каста)
    public float healthRegen;       // Регенерация здоровья
    public float manaRegen;         // Регенерация маны
    public float healingPower;      // Сила лечения
    public int petHealth;           // Здоровье петов
    public float petDamage;         // Урон петов
}

