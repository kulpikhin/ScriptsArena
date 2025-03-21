using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterClass", menuName = "Characters/CharacterClass")]
public class CharacterClass : ScriptableObject
{
    public string className;
    public float damagePercentage;  // ���� (� ���������)
    public int armor;               // �����
    public int health;              // ��������
    public int mana;                // ����
    public float dodgeChance;       // ���� ���������
    public float critChance;        // ���� �����
    public float critDamage;        // ���� ����
    public float vampirism;         // ���������
    public float ccResistance;      // ������������� ��������
    public float abilityCooldown;   // �������� �������������� ������������
    public float speed;             // �������� (����� � �����)
    public float healthRegen;       // ����������� ��������
    public float manaRegen;         // ����������� ����
    public float healingPower;      // ���� �������
    public int petHealth;           // �������� �����
    public float petDamage;         // ���� �����
}

