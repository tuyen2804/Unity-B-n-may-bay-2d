using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteByTime : Delete
{
    [SerializeField] public float timeDelete = 0.5f;
    [SerializeField] public float timeCount = 0f;
    protected override bool CanDelete()
    {
        this.timeCount += Time.fixedDeltaTime;
        if(this.timeCount > this.timeDelete)
        {
            this.timeCount = 0f;
            return true;
        }
        return false;
    }
}
