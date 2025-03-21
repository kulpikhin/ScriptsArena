using UnityEngine;

public class PoisonEffect : Effect
{
    public override void OnUpdate(GameObject target)
    {
        // Наносим периодический урон
        var character = target.GetComponent<Character>();
        if (character != null)
        {
            int damage = potency; // Урон от яда
            character.HealthCharacter.TakeDamage(damage);
            Debug.Log(target.name + " takes " + damage + " poison damage.");
        }
    }
}
