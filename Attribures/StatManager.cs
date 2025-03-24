using UnityEngine;

public class StatManager : MonoBehaviour
{
    // Публичные поля для характеристик персонажа
    public float BaseSpeed = 1.0f;
    public float BaseDamage = 10.0f;

    // Текущие значения характеристик с учетом постоянных модификаторов от предметов
    public Health HealthCharacter { get; private set; }
    public Mana ManaCharacter { get; private set; }
    public float Speed { get; private set; }
    public float Damage { get; private set; }

    void Start()
    {
        // Изначально текущие значения равны базовым
        Speed = BaseSpeed;
        Damage = BaseDamage;
    }

    // Добавляем постоянные модификаторы от предметов
    public void AddSpeedBonus(float bonus)
    {
        Speed += bonus;
        Debug.Log("Speed updated to: " + Speed);
    }

    public void AddDamageBonus(float bonus)
    {
        Damage += bonus;
        Debug.Log("Damage updated to: " + Damage);
    }
}

