using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    private StatManager statManager;
    private List<float> speedModifiers = new List<float>();

    void Start()
    {
        statManager = GetComponent<StatManager>();
    }

    // ���������� ���������� ������������ �������� (��������, �� ChillEffect)
    public void AddSpeedModifier(float modifier)
    {
        speedModifiers.Add(modifier);
        UpdateCurrentSpeed();
    }

    // �������� ���������� ������������ ��������
    public void RemoveSpeedModifier(float modifier)
    {
        if (speedModifiers.Contains(modifier))
        {
            speedModifiers.Remove(modifier);
            UpdateCurrentSpeed();
        }
    }

    // �������� ������� ��������
    private void UpdateCurrentSpeed()
    {
        float baseSpeed = statManager.Speed;  // ����� ������� �������� � ������ ���������
        float totalModifier = 1.0f;

        foreach (float modifier in speedModifiers)
        {
            totalModifier *= modifier;  // ������ ��� ��������� ������������
        }

        float currentSpeed = baseSpeed * totalModifier;
        currentSpeed = Mathf.Max(currentSpeed, 0.1f);  // ����������� ��������
        Debug.Log("Updated speed: " + currentSpeed);
    }
}
