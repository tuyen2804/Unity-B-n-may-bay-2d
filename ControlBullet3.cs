using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBullet3 : MonoBehaviour
{
    [SerializeField] public float speedBullet = 1.7f;
    [SerializeField] public Vector3 moveVector = new Vector3(0.3f, -1, 0);

    private void Update()
    {

        transform.parent.Translate(moveVector * speedBullet * Time.deltaTime);
    }
}
