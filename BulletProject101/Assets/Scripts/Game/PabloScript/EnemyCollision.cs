using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{


    //Health can be changed on Unity
    public int health = 1;
    private ScoreManager scoreManager;


    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    //Triggered when 2 Objects collide onto one another
    void OnTriggerEnter2D() 
    {
        
        Debug.Log ("Trigger");

        health--;
    }

    //Update when collision happens, checks if health is 0 
    void Update() {
        if (health <= 0) 
        {
          
            Die();
          
            
        }
    }

    //Destroys Object
    void Die() 
    {
        scoreManager.UpdateScore(10);
        Destroy(gameObject);
    }
}
