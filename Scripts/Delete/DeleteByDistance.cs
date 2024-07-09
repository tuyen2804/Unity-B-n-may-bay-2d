using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteByDistance : Delete
{
    [SerializeField] public float distanceDelete=13f;
    [SerializeField] public float distanceCamera=0f;
    protected override bool CanDelete()
    {
        this.distanceCamera = Vector3.Distance(transform.position, Camera.main.transform.position);
        if (this.distanceCamera > this.distanceDelete) return true;
        return false;
    }
}
