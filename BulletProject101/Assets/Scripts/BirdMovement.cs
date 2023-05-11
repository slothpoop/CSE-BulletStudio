using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float speed = 5f;

    private bool movingLeft = true;
    private float rightBoundary = 10f; // Set the right boundary of the screen

    // Update is called once per frame
    void Update()
    {
        // Check if the enemy has reached the right boundary of the screen
        if (transform.position.x >= rightBoundary)
        {
            movingLeft = true;
        }

        // Check if the enemy is moving to the left
        if (movingLeft)
        {
            // Move the enemy to the left
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        else
        {
            // Move the enemy to the right
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}
