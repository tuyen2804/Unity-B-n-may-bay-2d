using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] public float timeDelay = 2f;
    [SerializeField] public float time = 0f;
    private void FixedUpdate()
    {
        this.time += Time.fixedDeltaTime;
        if (this.time > timeDelay)
        {
            this.time = 0f;
            Transform newbullet = SpawnBullet.Instance.SpawnObject("BulletEnemy_1", transform.parent.position);
        }

    }
}
