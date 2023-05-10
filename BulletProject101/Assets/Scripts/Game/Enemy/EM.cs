using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EM : MonoBehaviour
{
    public float moveSpeed = 5;
    public bool moveRight = true;

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        // Move right if moveRight is true, move left if false
        if (moveRight)
        {
            pos.x += moveSpeed * Time.fixedDeltaTime;
        }
        else
        {
            pos.x -= moveSpeed * Time.fixedDeltaTime;
        }

        transform.position = pos;
    }
}