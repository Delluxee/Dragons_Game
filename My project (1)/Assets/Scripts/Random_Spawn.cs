using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Spawn : MonoBehaviour
{
    public GameObject[] enemigos;
    public GameObject[] spawnPoints;
 
    public float Tiempo_Respawn = 0.5f;

    public float Repetir_Respawn = 1;
    
    public Transform XRangeLeft;
    public Transform XRangeLeft_2;
    public Transform XRangeLeft_3;
    public Transform XRangeLeft_4;

    public float difficultyTime = 0;

    private void Start()
    {
        //InvokeRepeating("SpawnEnemigos", Tiempo_Respawn, Repetir_Respawn);
        StartCoroutine("EnemyDifficulty");
    }

    private void Update()
    {
        difficultyTime += Time.deltaTime;

        if(difficultyTime > 10 && difficultyTime < 20)
        {
            Repetir_Respawn = 3;
        }
        if(difficultyTime > 20 && difficultyTime < 30)
        {
            Repetir_Respawn = 2;
        }
        if(difficultyTime > 30 && difficultyTime < 40)
        {
            Repetir_Respawn = 1;
        }
        if(difficultyTime > 40 && difficultyTime < 50)
        {
            Repetir_Respawn = 0.75f;
        }
        if(difficultyTime > 60)
        {
            Repetir_Respawn = 0.25f;
        }
    }

    IEnumerator EnemyDifficulty()
    {
        yield return new WaitForSeconds(Repetir_Respawn);
        SpawnEnemigos();
        StartCoroutine("EnemyDifficulty");  
    }

    public void SpawnEnemigos()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(XRangeLeft.position.x, XRangeLeft_2.position.x), Random.Range(XRangeLeft_3.position.y, XRangeLeft_4.position.y), 0);

        GameObject enemigo = Instantiate(enemigos[Random.Range(0, enemigos.Length)], spawnPosition, gameObject.transform.rotation);
    }
}
