using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet: Spawn
{
    protected static SpawnBullet instance;
    public static SpawnBullet Instance {  get { return instance; } }
    protected override void Awake()
    {
        base.Awake();
        if (SpawnBullet.instance != null) Debug.Log("Only 1 SpawnBullet allow to exit");
        SpawnBullet.instance = this;
    }

}
