using UnityEngine;
using System.Collections;

public class CharacterAbilities : MonoBehaviour
{
    public Ability[] abilities;

    private float[] abilityCooldowns;
    private Coroutine[] cooldownCoroutines;
    private Character character;

    void Start()
    {
        abilityCooldowns = new float[abilities.Length];
        cooldownCoroutines = new Coroutine[abilities.Length];
        character = GetComponent<Character>();
    }

    void Update()
    {
        if (character != null && !character.isDead)
        {
            StopAllCoroutines();
            return;
        }

        for (int i = 0; i < abilityCooldowns.Length; i++)
        {
            if (abilityCooldowns[i] > 0)
            {
                abilityCooldowns[i] -= Time.deltaTime;
            }
        }
    }

    public void UseAbility(int index, GameObject target)
    {
        if (index < 0 || index >= abilities.Length)
        {
            Debug.LogError("Invalid ability index");
            return;
        }

        if (abilityCooldowns[index] <= 0)
        {
            if (abilities[index].manaCost <= character.statManager.ManaCharacter.CurrentMana)
            {
                abilities[index].Activate(target);
                abilityCooldowns[index] = abilities[index].cooldown;
                character.statManager.ManaCharacter.SpentMana((int)abilities[index].manaCost);

                if (cooldownCoroutines[index] != null)
                {
                    StopCoroutine(cooldownCoroutines[index]);
                }

                cooldownCoroutines[index] = StartCoroutine(CooldownRoutine(index));
            }
            else
            {
                Debug.Log("Not enough mana to use " + abilities[index].abilityName);
            }
        }
        else
        {
            Debug.Log(abilities[index].abilityName + " is on cooldown");
        }
    }

    private IEnumerator CooldownRoutine(int index)
    {
        while (abilityCooldowns[index] > 0)
        {
            if (character.isDead)
            {
                yield break;
            }

            abilityCooldowns[index] -= Time.deltaTime;
            yield return null;
        }

        cooldownCoroutines[index] = null;
    }
}