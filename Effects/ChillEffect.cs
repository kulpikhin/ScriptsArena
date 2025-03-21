using UnityEngine;

public class ChillEffect : Effect
{
    private float speedModifier;
    private SpeedManager speedManager;

    public override void OnApply(GameObject target)
    {
        speedManager = target.GetComponent<SpeedManager>();
        if (speedManager != null)
        {
            speedModifier = 1f - (potency / 100f);  // Рассчитываем модификатор уменьшения скорости
            speedManager.AddSpeedModifier(speedModifier);  // Применяем модификатор
            Debug.Log(target.name + " is chilled! Speed reduced.");
        }
    }

    public override void OnUpdate(GameObject target)
    {
        // Нет необходимости в периодическом обновлении для Chill
    }

    public override void OnRemove(GameObject target)
    {
        if (speedManager != null)
        {
            speedManager.RemoveSpeedModifier(speedModifier);  // Убираем модификатор при снятии эффекта
            Debug.Log(target.name + " is no longer chilled. Speed restored.");
        }
    }
}
