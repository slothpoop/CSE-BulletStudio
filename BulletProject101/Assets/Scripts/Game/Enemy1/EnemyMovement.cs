using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public enum states{
        straight,
        wavy
    }

    public states currentState;
    public float speed;

    [Header("Wavy Variables")]
    public float amplitude;
    public float period;
    public float shift;
    public float yChange;
    public float newX;
    public float newY;

    private Rigidbody2D myRigidbody;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    switch(currentState){
        case states.straight:
        myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, -speed);
        break;
      case states.wavy:
            newY = transform.position.y - yChange;
            newX = amplitude * Mathf.Sin(period * newY) + shift;
            Vector2 tempPosition = new Vector2(newX, newY);
            transform.position = tempPosition;
        break;
    }
}

}