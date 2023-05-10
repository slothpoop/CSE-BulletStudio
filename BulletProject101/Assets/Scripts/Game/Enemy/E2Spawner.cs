using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E2Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float initialSpawnDelay = 5f;

    private float nextSpawnTime;
    private bool hasSpawned = false;

    void Start()
    {
        nextSpawnTime = Time.time + initialSpawnDelay;
    }

    void Update()
    {
        if (!hasSpawned && Time.time >= nextSpawnTime)
        {
            GameObject spawnedEnemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
            spawnedEnemy.transform.rotation = transform.rotation;
            hasSpawned = true;
        }
    }

    public void ResetSpawner()
    {
        hasSpawned = false;
        nextSpawnTime = Time.time + initialSpawnDelay;
    }
}