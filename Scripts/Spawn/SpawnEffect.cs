using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEffect : Spawn
{
    protected static SpawnEffect instance;
    public static SpawnEffect Instance {  get { return instance; } }
    protected override void Awake()
    {
        base.Awake();
        if (SpawnEffect.instance != null) Debug.Log("Only 1 SpawnEffect allow to exit");
        SpawnEffect.instance = this;
    }
}
