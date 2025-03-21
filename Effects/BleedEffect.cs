using UnityEngine;

public class BleedEffect : Effect
{
    public override void OnUpdate(GameObject target)
    {
        // Наносим периодический урон
        var character = target.GetComponent<Character>();
        if (character != null)
        {
            int damage = potency * 2; // Урон от кровотечения
            character.HealthCharacter.TakeDamage(damage);
            Debug.Log(target.name + " takes " + damage + " bleed damage.");
        }
    }
}
