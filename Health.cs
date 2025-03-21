using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public event UnityAction<int> HealthChanged;

    public int CurrentHealth { get; private set; }
    public int MaxHealth { get; private set; }

    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            CurrentHealth = Mathf.Clamp(CurrentHealth - damage, 0, MaxHealth);

            HealthChanged?.Invoke(CurrentHealth);
        }
    }

    public void Heal(int healPower)
    {
        if (healPower > 0)
        {
            CurrentHealth = Mathf.Clamp(CurrentHealth + healPower, 0, MaxHealth);

            HealthChanged?.Invoke(CurrentHealth);
        }
    }

    public void SetMaxHealth(int newMaxHealth)
    {
        SetPositiveHealth(newMaxHealth);
    }

    public void AddMaxHealth(int term)
    {
        int newMaxHealth = MaxHealth + term;
        SetPositiveHealth(newMaxHealth);
    }

    private void SetPositiveHealth(int newMaxHealth)
    {
        if (newMaxHealth > 0)
        {
            MaxHealth = newMaxHealth;
        }
        else
        {
            MaxHealth = 1;
        }

        CurrentHealth = MaxHealth;
    }
}
