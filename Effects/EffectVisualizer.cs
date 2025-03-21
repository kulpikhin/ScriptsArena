using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EffectVisualizer : MonoBehaviour
{
    public EffectIcon effectIconPrefab; // ������ ������ �������
    public Transform effectsPanel;      // ������ ��� ������ ��� ����������

    private Dictionary<Effect, EffectIcon> activeEffectIcons = new Dictionary<Effect, EffectIcon>();

    public void AddEffect(Effect effect)
    {
        if (!activeEffectIcons.ContainsKey(effect))
        {
            // ������� ������ ��� �������
            EffectIcon iconObject = Instantiate(effectIconPrefab, effectsPanel);
            iconObject.InitializeEffectIcon(effect);  // �������������� ������ ������� �������

            activeEffectIcons[effect] = iconObject;

            // ��������� ���������� ������� �������
            StartCoroutine(UpdateEffectDuration(effect, iconObject));
        }
    }

    private System.Collections.IEnumerator UpdateEffectDuration(Effect effect, EffectIcon icon)
    {
        while (effect.duration > 0)
        {
            yield return new WaitForSeconds(1f);  // ��������� ������ �������
            effect.duration -= 1f;
            icon.UpdateTimerText(effect.duration);  // ��������� ����� �������
        }

        // ������� ������ ����� ����������
        RemoveEffect(effect);
    }

    public void RemoveEffect(Effect effect)
    {
        if (activeEffectIcons.ContainsKey(effect))
        {
            Destroy(activeEffectIcons[effect].gameObject);  // ������� ������ ������
            activeEffectIcons.Remove(effect);
        }
    }
}
