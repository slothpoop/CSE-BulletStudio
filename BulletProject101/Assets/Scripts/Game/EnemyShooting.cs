using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // The bullet prefab to use
    public Transform firePoint; // The point from where to fire the bullet
    public float bulletSpeed = 5f; // The speed of the bullet
    public float fireRate = 1f; // The rate of fire (in bullets per second)
    public float shootRange = 5f; // The range at which the enemy can shoot
    private float fireTimer; // Timer to keep track of when to fire next

    void Update()
    {
        // Check if the player is in range and it's time to fire
        if (CanShoot() && Time.time >= fireTimer)
        {
            // Fire a bullet
            FireBullet();
            // Reset the timer
            fireTimer = Time.time + 1f / fireRate;
        }
    }

    bool CanShoot()
    {
        // Check if the player is within shooting range
        Vector2 direction = transform.right;
        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, direction, shootRange);
        if (hit.collider != null && hit.collider.CompareTag("Player"))
        {
            return true;
        }
        return false;
    }

    void FireBullet()
    {
        // Instantiate a new bullet
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        // Set the bullet's speed and direction
        Vector2 direction = transform.right;
        bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }

    // Handle collision with the player
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Destroy the player
            Destroy(collision.gameObject);
        }
    }
}