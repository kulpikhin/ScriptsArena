using UnityEngine;

public class StatManager : MonoBehaviour
{
    // ��������� ���� ��� ������������� ���������
    public float BaseSpeed = 1.0f;
    public float BaseDamage = 10.0f;

    // ������� �������� ������������� � ������ ���������� ������������� �� ���������
    public Health HealthCharacter { get; private set; }
    public Mana ManaCharacter { get; private set; }
    public float Speed { get; private set; }
    public float Damage { get; private set; }

    void Start()
    {
        // ���������� ������� �������� ����� �������
        Speed = BaseSpeed;
        Damage = BaseDamage;
    }

    // ��������� ���������� ������������ �� ���������
    public void AddSpeedBonus(float bonus)
    {
        Speed += bonus;
        Debug.Log("Speed updated to: " + Speed);
    }

    public void AddDamageBonus(float bonus)
    {
        Damage += bonus;
        Debug.Log("Damage updated to: " + Damage);
    }
}

