using UnityEngine;

public static class EffectFactory
{
    public static void ApplyEffect(EffectType effectType, GameObject target)
    {
        // �������� ������ ������� �� ���������
        EffectData effectData = EffectDataManager.Instance.GetEffectData(effectType);

        if (effectData != null && effectData.effectPrefab != null)
        {
            // ������������ ������ �������
            GameObject effectObject = GameObject.Instantiate(effectData.effectPrefab);
            Effect effect = effectObject.GetComponent<Effect>();

            if (effect != null)
            {
                effect.effectData = effectData;
                effect.InitializeFromData();
                target.GetComponent<EffectVisualizer>().AddEffect(effect);
            }
        }
        else
        {
            Debug.LogWarning($"EffectData or prefab for {effectType} not found.");
        }
    }
}
