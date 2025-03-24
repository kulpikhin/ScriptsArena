using UnityEngine;

public class BurnEffect : Effect
{
    public override void OnUpdate(GameObject target)
    {
        // ������� ������������� ����
        var character = target.GetComponent<Character>();
        if (character != null)
        {
            int damage = potency/2; // ���� �� �������
            character.statManager.HealthCharacter.TakeDamage(damage);
            Debug.Log(target.name + " takes " + damage + " fire damage from Burn.");
        }
    }
}
