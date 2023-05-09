using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
   public GameObject enemyPrefab;
   private bool hasSpawned = false;
   public float spawnInterval = 10f;
   private float spawnTime = 0f;

void Update() {
    if (!hasSpawned && Time.time >= spawnTime + spawnInterval) {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        hasSpawned = true;
        spawnTime = Time.time;
    }
  }
}
