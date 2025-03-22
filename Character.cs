using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private SubClass characterSubClass;
    private StatManager statManager;

    void Start()
    {
        if (statManager == null)
        {
            statManager = GetComponent<StatManager>();
        }
    }
}
