using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    //Health can be changed on Unity
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar1 healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    
   //Triggered when 2 Objects collide onto one another
    void OnTriggerEnter2D() {
        Debug.Log ("Trigger");

        currentHealth--;

        healthBar.SetHealth(currentHealth);
    }

    //Update when collision happens, checks if health is 0 
    void Update() {
        if (currentHealth <= 0) {
            Die();
        }
    }

    //Destroys Object
    void Die() {
        Destroy(gameObject);
    }
}
