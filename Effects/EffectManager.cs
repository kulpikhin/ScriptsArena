using UnityEngine;
using System.Collections.Generic;

public class EffectDataManager : MonoBehaviour
{
    private static EffectDataManager instance;
    public static EffectDataManager Instance => instance;

    private Dictionary<EffectType, EffectData> effectDataDictionary = new Dictionary<EffectType, EffectData>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // Менеджер сохраняется между сценами
            LoadAllEffectData();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void LoadAllEffectData()
    {
        // Загружаем все объекты EffectData из папки Resources/EffectData
        EffectData[] allEffectData = Resources.LoadAll<EffectData>("EffectData");

        foreach (EffectData data in allEffectData)
        {
            if (!effectDataDictionary.ContainsKey(data.TypeEffect))
            {
                effectDataDictionary[data.TypeEffect] = data;
                Debug.Log("Loaded EffectData for: " + data.TypeEffect);
            }
        }
    }

    public EffectData GetEffectData(EffectType effectType)
    {
        if (effectDataDictionary.TryGetValue(effectType, out EffectData effectData))
        {
            return effectData;
        }

        Debug.LogWarning("EffectData not found for: " + effectType);
        return null;
    }
}


