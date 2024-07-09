using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteItem : DeleteByDistance
{
    private static DeleteItem instance;
    [SerializeField] public static DeleteItem Instance {
        get { return instance; } }
    protected override void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Only 1 DeleteItem allow to exist");
        }
        instance = this;
    }
    public override void DeleteObject()
    {
        base.DeleteObject();
        SpawnItem.Instance.Despawn(transform.parent);
    }
}
