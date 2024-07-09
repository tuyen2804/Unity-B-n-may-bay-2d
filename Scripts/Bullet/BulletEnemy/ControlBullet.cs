using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBullet : MonoBehaviour
{
    [SerializeField] float speedBullet = 4f;
    public Vector3 direction= new Vector3(0,1,0);
    protected void Update()
    {
        transform.parent.Translate(direction*this.speedBullet*Time.deltaTime);
    }
}
