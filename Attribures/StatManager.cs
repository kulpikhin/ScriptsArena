using UnityEngine;

public class StatManager : MonoBehaviour
{
    // ��������� ���� ��� ������������� ���������
    public float BaseSpeed = 1.0f;
    public int BaseHealth = 100;
    public float BaseDamage = 10.0f;

    // ������� �������� ������������� � ������ ���������� ������������� �� ���������
    public float Speed { get; private set; }
    public int Health { get; private set; }
    public float Damage { get; private set; }

    void Start()
    {
        // ���������� ������� �������� ����� �������
        Speed = BaseSpeed;
        Health = BaseHealth;
        Damage = BaseDamage;
    }

    // ��������� ���������� ������������ �� ���������
    public void AddSpeedBonus(float bonus)
    {
        Speed += bonus;
        Debug.Log("Speed updated to: " + Speed);
    }

    public void AddHealthBonus(int bonus)
    {
        Health += bonus;
        Debug.Log("Health updated to: " + Health);
    }

    public void AddDamageBonus(float bonus)
    {
        Damage += bonus;
        Debug.Log("Damage updated to: " + Damage);
    }
}

