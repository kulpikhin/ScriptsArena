using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Effect Data", menuName = "Effect System/Effect Data")]
public class EffectData : ScriptableObject
{
    public EffectType TypeEffect;         // Тип эффекта
    public GameObject effectPrefab;       // Префаб эффекта
    public Sprite Icon;
    public float Duratuin;
    public int Potency;
}
