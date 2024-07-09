using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBullet : DeleteByDistance
{
    public override void DeleteObject()
    {
        base.DeleteObject();
        SpawnBullet.Instance.Despawn(transform.parent);
    }
}
