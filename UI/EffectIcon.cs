using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EffectIcon : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private Image icon;
    [SerializeField] private Image frame;

    public void InitializeEffectIcon(Effect effect)
    {
        icon.sprite = effect.GetEffectIcon();  // Устанавливаем иконку
        UpdateTimerText(effect.duration);
    }
    
    public void UpdateTimerText(float duration)
    {
        timerText.text = duration.ToString(); // Обновляем текст таймера
    }
}

