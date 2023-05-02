using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting1 : MonoBehaviour
{
    
    public Transform gunpoint;
    public GameObject enemyBullet;

    public float shootSpeed;
    private float shootSpeedTime;

    void Start()
    {
        shootSpeedTime = shootSpeed;
    }

    void Update()
    {
        if (shootSpeedTime <= 0)
        {
            Shoot();
            shootSpeedTime = shootSpeed;
        }
        else
        {
            shootSpeedTime -= Time.deltaTime;
        }
    }


    void Shoot()
    {
        GameObject bulletGO = Instantiate(enemyBullet, gunpoint.position, gunpoint.rotation) as GameObject;
        Destroy (bulletGO, 5f);
    }
}

