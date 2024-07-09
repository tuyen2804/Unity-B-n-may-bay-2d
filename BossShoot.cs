using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShoot : MonoBehaviour
{
    [SerializeField] public float timeDelay = 1f;
    [SerializeField] public float time = 0f;
    private void FixedUpdate()
    {
        this.time += Time.fixedDeltaTime;
        if (this.time > timeDelay)
        {
            this.time = 0f;
            Transform newbullet1 = SpawnBullet.Instance.SpawnObject("BulletEnemy_1", transform.parent.position);
            Transform newbullet2 = SpawnBullet.Instance.SpawnObject("BulletEnemy_2", transform.parent.position);
            Transform newbullet3 = SpawnBullet.Instance.SpawnObject("BulletEnemy_3", transform.parent.position);
        }

    }
}
