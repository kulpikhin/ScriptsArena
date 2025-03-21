using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewAbility", menuName = "Abilities/Ability")]
public class Ability : ScriptableObject
{
    public string abilityName;
    public string description;
    public float damage;            // ���� �����������
    public float manaCost;          // ��������� ����
    public float cooldown;          // ����� ��������������
    public List<AbilityType> abilityTypes; // ���� ����������� (��������, ����, �������, ����)
    public List<AbilityTag> tags;       // ���� ����������� (��������, "������", "��������", "�������")

    public virtual void Activate(GameObject target)
    {
        Debug.Log(abilityName + " activated on " + target.name);
        // ���������� ������ ��������� �����������
    }
}
