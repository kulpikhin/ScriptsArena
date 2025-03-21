using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Effect Data", menuName = "Effect System/Effect Data")]
public class EffectData : ScriptableObject
{
    public EffectType TypeEffect;         // ��� �������
    public GameObject effectPrefab;       // ������ �������
    public Sprite Icon;
    public float Duratuin;
    public int Potency;
}
