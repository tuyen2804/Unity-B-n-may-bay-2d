using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipEnemyCtrl : SaiMonoBehaviour
{
    [SerializeField] protected Transform model;
    public Transform Model { get => model; }

    [SerializeField] protected ShipSO shipSO;
    public ShipSO ShipSO => shipSO;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadModel();
        this.LoadShipSO();
    }

    protected virtual void LoadModel()
    {
        if (this.model != null) return;
        this.model = transform.Find("Model");
        Debug.Log(transform.name + ": LoadModel", gameObject);
    }


    protected virtual void LoadShipSO()
    {
        if (this.shipSO != null) return;
        string resPath = "ShipEnemy/" + transform.name;
        this.shipSO = Resources.Load<ShipSO>(resPath);
        Debug.Log(transform.name + ": LoadShipSO " + resPath, gameObject);
    }
    public void DeleteShipEnemy()
    {
        SpawnItem.Instance.SpawnObject("Item_1", transform.position);
        SpawnEffect.Instance.SpawnObject("Explosion", transform.position);
        AudioManager.Instance.Hit();
        SpawnShipEnemy.Instance.Despawn(transform);
    }
}
