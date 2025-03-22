using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    private StatManager statManager;
    private List<float> speedModifiers = new List<float>();

    public float CurrentSpeed { get; private set; }

    void Start()
    {
        statManager = GetComponent<StatManager>();
    }

    // Добавление временного модификатора скорости (например, от ChillEffect)
    public void AddSpeedModifier(float modifier)
    {
        speedModifiers.Add(modifier);
        UpdateCurrentSpeed();
    }

    // Удаление временного модификатора скорости
    public void RemoveSpeedModifier(float modifier)
    {
        if (speedModifiers.Contains(modifier))
        {
            speedModifiers.Remove(modifier);
            UpdateCurrentSpeed();
        }
    }

    // Пересчет текущей скорости
    private void UpdateCurrentSpeed()
    {
        float baseSpeed = statManager.Speed;  // Берем базовую скорость с учетом предметов
        float totalModifier = 1.0f;

        foreach (float modifier in speedModifiers)
        {
            totalModifier *= modifier;  // Множим все временные модификаторы
        }

        CurrentSpeed = Mathf.Max(baseSpeed * totalModifier, 0.1f);  // Минимальная скорость
    }
}
