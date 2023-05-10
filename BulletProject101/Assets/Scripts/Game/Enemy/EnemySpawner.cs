using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefabs;
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
            Instantiate(enemyPrefabs, transform.position, Quaternion.identity);
            hasSpawned = true;
        }
    }

    public void ResetSpawner()
    {
        hasSpawned = false;
        nextSpawnTime = Time.time + initialSpawnDelay;
    }
}
