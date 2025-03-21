using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EffectVisualizer : MonoBehaviour
{
    public EffectIcon effectIconPrefab; // Префаб иконки эффекта
    public Transform effectsPanel;      // Панель для иконок над персонажем

    private Dictionary<Effect, EffectIcon> activeEffectIcons = new Dictionary<Effect, EffectIcon>();

    public void AddEffect(Effect effect)
    {
        if (!activeEffectIcons.ContainsKey(effect))
        {
            // Создаем иконку для эффекта
            EffectIcon iconObject = Instantiate(effectIconPrefab, effectsPanel);
            iconObject.InitializeEffectIcon(effect);  // Инициализируем иконку данными эффекта

            activeEffectIcons[effect] = iconObject;

            // Запускаем обновление времени эффекта
            StartCoroutine(UpdateEffectDuration(effect, iconObject));
        }
    }

    private System.Collections.IEnumerator UpdateEffectDuration(Effect effect, EffectIcon icon)
    {
        while (effect.duration > 0)
        {
            yield return new WaitForSeconds(1f);  // Обновляем каждую секунду
            effect.duration -= 1f;
            icon.UpdateTimerText(effect.duration);  // Обновляем текст таймера
        }

        // Удаляем эффект после завершения
        RemoveEffect(effect);
    }

    public void RemoveEffect(Effect effect)
    {
        if (activeEffectIcons.ContainsKey(effect))
        {
            Destroy(activeEffectIcons[effect].gameObject);  // Удаляем объект иконки
            activeEffectIcons.Remove(effect);
        }
    }
}
