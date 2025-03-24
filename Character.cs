using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public SubClass characterSubClass;
    public StatManager statManager;

    public bool isDead { get; private set; }

    private void Start()
    {
        statManager = GetComponent<StatManager>();
    }

    private void CheckDeath(int health)
    {
        if (health <= 0)
        {
            isDead = true;
        }
    }
}
