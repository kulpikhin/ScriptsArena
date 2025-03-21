using UnityEngine;

public abstract class Effect : MonoBehaviour
{
    public EffectData effectData;  // ����� � ������� �������
    public float duration;         // ������������ �������
    public int potency;            // ���� �������

    public virtual void OnApply(GameObject target)
    {
        Debug.Log(effectData.TypeEffect + " applied to " + target.name);
    }

    public virtual void OnUpdate(GameObject target) { }

    public virtual void OnRemove(GameObject target)
    {
        Debug.Log(effectData.TypeEffect + " removed from " + target.name);
    }

    public void InitializeFromData()
    {
        duration = effectData.Duratuin;
        potency = effectData.Potency;
    }

    public Sprite GetEffectIcon()
    {
        return effectData.Icon;
    }
}