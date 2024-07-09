using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : Spawn
{
    protected static SpawnItem instance;
    public static SpawnItem Instance {  get { return instance; } }
    protected override void Awake()
    {
        base.Awake();
        if (SpawnItem.instance != null) Debug.Log("Only 1 SpawnItem allow to exit");
        SpawnItem.instance = this;
    }
}
