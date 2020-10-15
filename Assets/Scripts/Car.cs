using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    public Rigidbody2D Rigid;

    float Speed = 1f;

    public float MinSpeed = 3f;
    public float MaxSpeed = 8f;


    void Start()
    {
        Speed = Random.Range(MinSpeed, MaxSpeed);
    }

    // Used documents https://docs.unity3d.com/ScriptReference/Time-fixedDeltaTime.html
    // https://docs.unity3d.com/ScriptReference/MonoBehaviour.FixedUpdate.html
    

    void FixedUpdate()
    {
        // Storing Vector2 forward so we can keep moving "forward" in any rotation.

        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        Rigid.MovePosition(Rigid.position + forward * Time.fixedDeltaTime * Speed);
    }
}
