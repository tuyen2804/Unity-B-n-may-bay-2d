using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlShipBoss : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float speedShip = 1f;
    Vector3 moveVetor = new Vector3(0, -1, 0);
    public float distanceToCam;
    private void Update()
    {

        this.distanceToCam=Vector3.Distance(transform.position, Vector3.zero);
        if(this.distanceToCam <=3f)
        {
            speedShip = 0f;
        }
        transform.parent.Translate(moveVetor * speedShip * Time.deltaTime);
        
    }
}
