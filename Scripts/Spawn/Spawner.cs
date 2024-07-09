using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : SaiMonoBehaviour
{
    [SerializeField] public List<Transform> prefabs;
    [SerializeField] public Transform holder;
    [SerializeField] public List<Transform> poolObject;

    protected override void Awake()
    {
        base.Awake();
        this.LoadComponents();
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPrefabs();
        this.LoadHolder();
    }
    protected virtual void LoadPrefabs()
    {

        Transform Prefabs = transform.Find("Prefabs");
        if (this.prefabs == null) return;
        foreach (Transform child in Prefabs)
        {
            child.gameObject.SetActive(false);
            this.prefabs.Add(child);
        }
    }
    protected virtual void LoadHolder()
    {
        if (this.holder != null) return;
        this.holder = transform.Find("Holder");
    }
    public virtual Transform SpawnObject(string nameobj, Vector3 position)
    {
        Transform t = this.GetObjectbyprefabs(nameobj);
        if (t == null) return null;
        Transform obj = this.GetObjectbypool(t);
        obj.gameObject.SetActive(true);
        obj.parent = this.holder;
        obj.position = position;
        return obj;

    }
    public virtual void Despawn(Transform obj)
    {
        if (obj == null) return;
        obj.gameObject.SetActive(false);
        this.poolObject.Add(obj);
    }
    Transform GetObjectbypool(Transform Effect)
    {
        foreach (Transform child in this.poolObject)
        {
            if (child.name == Effect.name)
            {
                this.poolObject.Remove(child);
                return child;
            }
        }
        Transform newobj = Instantiate(Effect);
        newobj.name = Effect.name;
        return newobj;
    }
    Transform GetObjectbyprefabs(string nameEffect)
    {
        foreach (Transform Child in this.prefabs)
        {
            if (Child.name == nameEffect) return Child;

        }
        return null;
    }
}
