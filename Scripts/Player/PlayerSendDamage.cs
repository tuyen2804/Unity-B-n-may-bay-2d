using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSendDamage: SaiMonoBehaviour
{
    public int damageAmount = 1; // Số lượng damage gửi đi

    public void OnTriggerEnter2D(Collider2D other)
    {
        // Kiểm tra va chạm với object thuyền địch
        if (other.CompareTag("EnemyReceive_1"))
        {
            // Gửi damage tới object thuyền địch
            other.GetComponent<EnemyReceive>().TakeDamage(damageAmount);
            // Hủy object đạn sau khi va chạm
            SpawnBullet.Instance.Despawn(transform.parent);
            SpawnEffect.Instance.SpawnObject("Hit",transform.position);
        }
        if (other.CompareTag("EnemyReceive_2"))
        {
            // Gửi damage tới object thuyền địch
            other.GetComponent<DeleteShipBoss>().TakeDamage(damageAmount);
            // Hủy object đạn sau khi va chạm
            SpawnBullet.Instance.Despawn(transform.parent);
            SpawnEffect.Instance.SpawnObject("Hit", transform.position);
        }
    }
}
