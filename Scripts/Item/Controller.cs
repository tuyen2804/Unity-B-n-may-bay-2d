using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerItem:SaiMonoBehaviour 
{
    [SerializeField] public float speedMove = 1.2f;
    [SerializeField] public Vector3 vectorMove=new Vector3(0,-1,0);
    protected void Update()
    {
        transform.parent.Translate(vectorMove*speedMove*Time.deltaTime);
    }
}
