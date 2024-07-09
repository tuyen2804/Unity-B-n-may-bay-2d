using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shoot : SaiMonoBehaviour
{
    [SerializeField] public float shootDelay = 0.6f;
    [SerializeField] protected float shootTimer = 0f;
    private static Shoot instance;
    [SerializeField] public static Shoot Instance { get { return instance; } }
    protected override void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Only 1 Shootplayer allow to exist");
        }
        instance = this;
    }

    private void FixedUpdate()
    {
        this.Shooting();
    }

    protected virtual void Shooting()
    {
        this.shootTimer += Time.fixedDeltaTime;
        if (this.shootTimer < this.shootDelay) return;
        this.shootTimer = 0;

        Vector3 spawnPos = transform.position;

        Transform newBullet = SpawnBullet.Instance.SpawnObject("Bullet_1", spawnPos);
        if (newBullet == null) return;

        newBullet.gameObject.SetActive(true);
        Debug.Log("Shooting");
    }
}