using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBulletEnemy : MonoBehaviour
{
    [SerializeField] public float speedBullet = 1.7f;
    [SerializeField] public Vector3 moveVector = new Vector3(0, -1, 0);

    private void Update()
    {
       
        transform.parent.Translate(moveVector*speedBullet*Time.deltaTime);
    }
}
