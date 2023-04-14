using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting1 : MonoBehaviour
{
    
    public Transform gunpoint;
    public GameObject enemyBullet;
    public float enemyBulletSpawnTime = 0.5f;


    void Start()
    {
        StartCoroutine(EnemyShooting());
    }

    void EnemyFire()
    {
        Instantiate(enemyBullet, gunpoint.position, Quaternion.identity);
        
    }

    IEnumerator EnemyShooting()
    {
        yield return new WaitForSeconds(enemyBulletSpawnTime);
        EnemyFire();
    }

}

