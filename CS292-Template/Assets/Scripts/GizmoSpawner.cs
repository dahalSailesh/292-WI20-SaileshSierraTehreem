using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] fries;
    float startTimeBtwSpawns;

    private float timeBtwSpawns;


    private void Update()
    {
        GameObject randomfries;
        startTimeBtwSpawns = Random.Range(9.0f, 12.0f);
        if (timeBtwSpawns <= 0)
        {
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            randomfries = fries[0];

            Instantiate(randomfries, randomSpawnPoint.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
            if (timeBtwSpawns <= 3.0)
            {
                Destroy(GameObject.FindGameObjectWithTag("Fries"));
            }
        }
    }

}