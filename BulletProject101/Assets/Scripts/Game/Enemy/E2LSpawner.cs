using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E2LSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float initialSpawnDelay = 5f;
    public Vector3 rotationOffset = new Vector3(0f, -90f, 0f); // Rotation offset for the spawned enemy

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
            Quaternion desiredRotation = Quaternion.Euler(transform.rotation.eulerAngles + rotationOffset);
            GameObject spawnedEnemy = Instantiate(enemyPrefab, transform.position, desiredRotation);
            hasSpawned = true;
        }
    }

    public void ResetSpawner()
    {
        hasSpawned = false;
        nextSpawnTime = Time.time + initialSpawnDelay;
    }
}
