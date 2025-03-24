using UnityEngine;

public class BurnEffect : Effect
{
    public override void OnUpdate(GameObject target)
    {
        // Наносим периодический урон
        var character = target.GetComponent<Character>();
        if (character != null)
        {
            int damage = potency/2; // Урон от поджога
            character.statManager.HealthCharacter.TakeDamage(damage);
            Debug.Log(target.name + " takes " + damage + " fire damage from Burn.");
        }
    }
}
