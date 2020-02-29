using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCarRightLevelOne : MonoBehaviour
{
    public Transform[] spawnPoints1;
    public GameObject[] hazards1;
    float startTimeBtwSpawns1;

    private float timeBtwSpawns1;

    private void Update()
    {
        startTimeBtwSpawns1 = Random.Range(2.5f, 3.0f);
        if (timeBtwSpawns1 <= 0)
        {
            Transform randomSpawnPoint1 = spawnPoints1[Random.Range(0, spawnPoints1.Length)];
            GameObject randomHazard1 = hazards1[Random.Range(0, hazards1.Length)];

            Instantiate(randomHazard1, randomSpawnPoint1.position, Quaternion.identity);
            timeBtwSpawns1 = startTimeBtwSpawns1;


        }
        else
        {
            timeBtwSpawns1 -= Time.deltaTime;
        }
    }

}
