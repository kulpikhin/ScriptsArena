using UnityEngine;

[CreateAssetMenu(fileName = "NewSubClass", menuName = "Characters/SubClass")]
public class SubClass : ScriptableObject
{
    public CharacterClass baseClass;  // �������� ����� (��������, ���, ����)
    public string subClassName;
    public string description;
}
