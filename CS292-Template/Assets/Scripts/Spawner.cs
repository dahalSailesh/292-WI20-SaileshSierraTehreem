using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] hazards;
    float startTimeBtwSpawns = 3.25f;

    private float timeBtwSpawns;

    private void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject randomHazard = hazards[Random.Range(0, hazards.Length)];

            Instantiate(randomHazard, randomSpawnPoint.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;


        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }

}
