using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    float shipBoundaryRadius = 0.7f;
    
    void Update()
    {
        Vector3 pos = transform.position;

        if(pos.y+shipBoundaryRadius > Camera.main.orthographicSize) 
        {
            pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
        }
        if(pos.y-shipBoundaryRadius < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
        }   

        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        if(pos.x+shipBoundaryRadius > widthOrtho) 
        {
            pos.x = widthOrtho - shipBoundaryRadius;
        }
        if(pos.x-shipBoundaryRadius < -widthOrtho)
        {
            pos.x = -widthOrtho + shipBoundaryRadius;
        }

        transform.position = pos;
    }
}
