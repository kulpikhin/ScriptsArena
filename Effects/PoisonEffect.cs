using UnityEngine;

public class PoisonEffect : Effect
{
    public override void OnUpdate(GameObject target)
    {
        // ������� ������������� ����
        var character = target.GetComponent<Character>();
        if (character != null)
        {
            int damage = potency; // ���� �� ���
            character.HealthCharacter.TakeDamage(damage);
            Debug.Log(target.name + " takes " + damage + " poison damage.");
        }
    }
}
