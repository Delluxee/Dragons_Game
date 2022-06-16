using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Spawn : MonoBehaviour
{
    public GameObject[] enemigos;

    public float Tiempo_Respawn = 1;

    public float Repetir_Respawn = 1;
    
    public Transform XRangeLeft;
    public Transform XRangeLeft_2;
    public Transform XRangeLeft_3;
    public Transform XRangeLeft_4;

    private void Start()
    {
        InvokeRepeating("SpawnEnemigos", Tiempo_Respawn, Repetir_Respawn);
    }

    public void SpawnEnemigos()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(XRangeLeft.position.x, XRangeLeft_2.position.x), Random.Range(XRangeLeft_3.position.y, XRangeLeft_4.position.y), 0);

        GameObject enemigo = Instantiate(enemigos[Random.Range(0, enemigos.Length)], spawnPosition, gameObject.transform.rotation);
    }
}
