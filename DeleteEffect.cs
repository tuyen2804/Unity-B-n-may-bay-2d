using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteEffect:DeleteByTime
{
    public override void DeleteObject()
    {
        base.DeleteObject();
        SpawnEffect.Instance.Despawn(transform.parent);
    }
}
