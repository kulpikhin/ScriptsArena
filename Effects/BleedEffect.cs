using UnityEngine;

public class BleedEffect : Effect
{
    public override void OnUpdate(GameObject target)
    {
        // ������� ������������� ����
        var character = target.GetComponent<Character>();
        if (character != null)
        {
            int damage = potency * 2; // ���� �� ������������
            character.HealthCharacter.TakeDamage(damage);
            Debug.Log(target.name + " takes " + damage + " bleed damage.");
        }
    }
}
