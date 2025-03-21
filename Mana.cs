using UnityEngine;
using UnityEngine.Events;

public class Mana : MonoBehaviour
{
    public event UnityAction<int> ManaChanged;

    public int CurrentMana { get; private set; }
    public int MaxMana { get; private set; }

    public void SpentMana(int cost)
    {
        if (cost > 0)
        {
            CurrentMana = Mathf.Clamp(CurrentMana - cost, 0, MaxMana);

            ManaChanged?.Invoke(CurrentMana);
        }
    }

    public void RestoreMana(int restorePower)
    {
        if (restorePower > 0)
        {
            CurrentMana = Mathf.Clamp(CurrentMana + restorePower, 0, MaxMana);

            ManaChanged?.Invoke(CurrentMana);
        }
    }

    public void SetMaxMana(int newMaxMana)
    {
        SetPositiveMana(newMaxMana);
    }

    public void AddMaxMana(int term)
    {
        int newMaxMana = MaxMana + term;
        SetPositiveMana(newMaxMana);
    }

    private void SetPositiveMana(int newMaxMana)
    {
        if (newMaxMana > 0)
        {
            MaxMana = newMaxMana;
        }
        else
        {
            MaxMana = 1;
        }

        CurrentMana = MaxMana;
    }
}
