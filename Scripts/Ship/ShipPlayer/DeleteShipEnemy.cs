using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteShipEnemy : DeleteByDistance
{
    public override void DeleteObject()
    {
        base.DeleteObject();
        SpawnShipEnemy.Instance.Despawn(transform.parent);
    }
}
