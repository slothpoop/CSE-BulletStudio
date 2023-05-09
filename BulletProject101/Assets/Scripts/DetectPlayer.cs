using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
public Transform player;
public float detectionDistance = 10f;
public float fireRate = 1f;
public GameObject bulletPrefab;
public Transform firePoint;

private float nextFireTime;

void Update()
{
    if (Vector2.Distance(transform.position, player.position) < detectionDistance)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, player.position - transform.position, detectionDistance);
        if (hit.collider != null && hit.collider.CompareTag("Player"))
        {
            if (Time.time >= nextFireTime)
            {
                Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                nextFireTime = Time.time + 1f / fireRate;

                Debug.DrawRay(transform.position,player.position - transform.position,Color.green);
            }
        }
    }
}
}
