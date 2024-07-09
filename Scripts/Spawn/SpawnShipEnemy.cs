using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShipEnemy : Spawn
{
    protected static SpawnShipEnemy instance;
    public static SpawnShipEnemy Instance {  get { return instance; } }
    protected override void Awake()
    {
        base.Awake();
        if (SpawnShipEnemy.instance != null) Debug.Log("Only 1 SpawnShipEnemy alow to exit");
        SpawnShipEnemy.instance = this;
    }
}
