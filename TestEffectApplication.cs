using UnityEngine;

public class EffectTester : MonoBehaviour
{
    public GameObject targetCharacter;  // ����, �� ������� ����� ����������� �������

    void Start()
    {
        // ��������� ������� ��� ������ ���� ��� �����
        ApplyBleedEffect();
        ApplyIgniteEffect();
    }

    public void ApplyBleedEffect()
    {
        EffectData bleedData = EffectDataManager.Instance.GetEffectData(EffectType.Bleed);
        if (bleedData != null)
        {
            EffectFactory.ApplyEffect(EffectType.Bleed, targetCharacter);
            Debug.Log("Bleed effect applied to " + targetCharacter.name);
        }
        else
        {
            Debug.LogWarning("BleedEffectData not found.");
        }
    }

    public void ApplyIgniteEffect()
    {
        EffectData igniteData = EffectDataManager.Instance.GetEffectData(EffectType.Burn);
        if (igniteData != null)
        {
            EffectFactory.ApplyEffect(EffectType.Burn, targetCharacter);
            Debug.Log("Ignite effect applied to " + targetCharacter.name);
        }
        else
        {
            Debug.LogWarning("IgniteEffectData not found.");
        }
    }
}

