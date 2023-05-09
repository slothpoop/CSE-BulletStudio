using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCollision : MonoBehaviour
{
    //Health can be changed on Unity
    public int maxHealth = 10;
    public int currentHealth;

    public HealthBar1 healthBar;

    private bool isDead;

    public GameObject LevelComplete;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        LevelComplete.SetActive(false);
    }
    
   //Triggered when 2 Objects collide onto one another
    void OnTriggerEnter2D() {
        Debug.Log ("Trigger");

        currentHealth--;

        healthBar.SetHealth(currentHealth);
    }

    //Update when collision happens, checks if health is 0 
    void Update() {
        if (currentHealth <= 0 && !isDead) {
            isDead = true;
            gameObject.SetActive(false);
            Die();
            Time.timeScale = 0f;
            LevelComplete.SetActive(true);
        }
    }

    //Destroys Object
    void Die() {
        Destroy(gameObject);
    }
}