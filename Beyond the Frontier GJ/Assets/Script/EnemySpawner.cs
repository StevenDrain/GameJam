using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    public int maxEnemies = 70;
    private int currentEnemies = 0;
    public ScoreManager sm;

    public Transform[] spawnPoints;
    // Update is called once per frame
    private int previousScore;

    void Start()
    {
        previousScore = sm.score;
    }

    void Update()
    {
        if (sm.score > previousScore)
        {
        if (currentEnemies < maxEnemies){
            SpawnEnemy();
            previousScore = sm.score;
        }
        }
    }

    void SpawnEnemy()
    {


        // Select a random number of enemies to spawn
        int numEnemies = Random.Range(0, 5); // The second parameter is exclusive, so 3 is not included

        for (int i = 0; i < numEnemies; i++)
        {
            // Select a random spawn point
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);

            // Instantiate an enemy at the spawn point
            Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

            currentEnemies++;
        }
    }
}
