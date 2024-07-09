using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Delete : SaiMonoBehaviour
{
    // Start is called before the first frame update
    protected virtual void Update()
    {
        this.Deleting();
    }
    protected virtual void Deleting()
    {
        if (!this.CanDelete()) return;
        this.DeleteObject();
    }
    public virtual void DeleteObject()
    {

    }
    protected abstract bool CanDelete();
}
