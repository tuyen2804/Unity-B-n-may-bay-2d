using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnShip : MonoBehaviour
{
    [SerializeField] public List<Transform> PointSpawn;
    [SerializeField] public float timeSpawnShip = 3f;
    [SerializeField] public float time1 = 0f;
    [SerializeField] public float time2 = 0f;
    [SerializeField] public float timeSpawnBoss = 21f;
    [SerializeField] Transform shipBoss;

    private void Awake()
    {

        this.LoadComponents();
    }
    void LoadComponents()
    {
        foreach (Transform t in transform)
        {
            this.PointSpawn.Add(t);
        }
    }
    private void FixedUpdate()
    {
        this.time1 += Time.fixedDeltaTime;
        this.time2 += Time.fixedDeltaTime;
        if (this.time1 < this.timeSpawnShip) return;
        
        if(this.time2 >= this.timeSpawnBoss) {
            if (this.shipBoss == null)
            {
                Transform spawnpoint = this.PointSpawnShipBoss();
                this.shipBoss = SpawnShipEnemy.Instance.SpawnObject("ShipEnemy_2", spawnpoint.position);
            }
            else return;
         
           
        }
        else
        {
            this.time1 = 0f;
            Transform spawnpoint = this.RandomPointSpawn();
            Transform newShip = SpawnShipEnemy.Instance.SpawnObject("ShipEnemy_1", spawnpoint.position);
            if (newShip == null) return;
            newShip.gameObject.SetActive(true);
        }

    }
    Transform PointSpawnShipBoss(string  namepoint= "Point_5")
    {

        foreach (Transform t in this.PointSpawn)
        {
            if (t.name == namepoint) return t;
        }
        return null;
    }
    Transform RandomPointSpawn()
    {
        string[] points = { "Point_1", "Point_2", "Point_3", "Point_4" };


        string randomTen = points[Random.Range(0, points.Length)];

        foreach (Transform t in this.PointSpawn)
        {
            if (t.name == randomTen) return t;
        }
        return null;
    }
}