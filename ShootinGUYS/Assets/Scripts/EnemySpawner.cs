using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemySpawn;
    public GameObject hero;

    private float timeBtwEnemies = 0.8f;
    private float spawnStart = 0.25f;
    private bool invokeEnemys;

    private void Start() 
    {
        InvokeRepeating("SpawnEnemies", spawnStart, timeBtwEnemies);
        invokeEnemys = true;
    }

    private void Update() 
    {
        if(hero == null && invokeEnemys == true)
        {
            CancelInvoke("SpawnEnemies");
            invokeEnemys = false;
        }
        RandomSpeed();
    }

    private void SpawnEnemies()
    {
        int rand = Random.Range(0, enemySpawn.Length);
        Instantiate(enemySpawn[rand], transform.position, Quaternion.identity);
    }

    private void RandomSpeed()
    {
        timeBtwEnemies = Random.Range(0.005f, 2.0f);
    }

}