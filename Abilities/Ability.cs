using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewAbility", menuName = "Abilities/Ability")]
public class Ability : ScriptableObject
{
    public string abilityName;
    public string description;
    public float damage;            // Урон способности
    public float manaCost;          // Стоимость маны
    public float cooldown;          // Время восстановления
    public List<AbilityType> abilityTypes; // Типы способности (например, урон, лечение, бафф)
    public List<AbilityTag> tags;       // Теги способности (например, "стихии", "усиление", "лечение")

    public virtual void Activate(GameObject target)
    {
        Debug.Log(abilityName + " activated on " + target.name);
        // Реализуйте логику активации способности
    }
}
