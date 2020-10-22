using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    // Bounds for the cars so they will be deleted at a certain point
    private float LeftBound = -22;
    private float RightBound = 22;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (transform.position.x < LeftBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > RightBound)
        {
            Destroy(gameObject);
        }
    }
}
