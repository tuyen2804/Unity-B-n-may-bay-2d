using UnityEngine;

public class EnemyReceive : SaiMonoBehaviour
{
    private int currentHealth; // Máu hiện tại của thuyền địch
    [SerializeField] protected ShipEnemyCtrl shipEnemyCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadShipEnemyCtrl();
    }
    protected override void Start()
    {
        base.Start();
        this.currentHealth = shipEnemyCtrl.ShipSO.hpMax;
    }
    protected virtual void LoadShipEnemyCtrl()
    {
        if (this.shipEnemyCtrl != null) return;
        this.shipEnemyCtrl = transform.parent.GetComponent<ShipEnemyCtrl>();
        Debug.Log(transform.name + ": LoadShipEnemyCtrl", gameObject);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage; // Giảm máu theo damage nhận được

        // Kiểm tra nếu máu đã hết
        if (currentHealth <= 0)
        {
            //SpawnItem.Instance.SpawnObject("Item_1",transform.position);
            //SpawnEffect.Instance.SpawnObject("Explosion", transform.position);
            //AudioManager.Instance.Hit();
            //SpawnShipEnemy.Instance.Despawn(transform.parent);
            shipEnemyCtrl.DeleteShipEnemy();
            this.currentHealth = shipEnemyCtrl.ShipSO.hpMax;
        }
    }

}

