using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossmovement : MonoBehaviour

{
public float speed = 5f;
public float amplitude = 2f;

private float horizontalInput; 
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Mathf.Sin(Time.time * speed) * amplitude;
        
        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);
        
    }
}
