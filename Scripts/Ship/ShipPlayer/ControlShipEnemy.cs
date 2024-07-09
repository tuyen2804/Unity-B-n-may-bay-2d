using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlShipEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float speedShip = 1f;
    Vector3 moveVetor= new Vector3 (0,-1,0);
    private void Update()
    {
        transform.parent.Translate(moveVetor*speedShip*Time.deltaTime);
    }
}
