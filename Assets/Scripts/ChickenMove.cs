using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenMove : MonoBehaviour
{
    public Rigidbody2D Rigid;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            Rigid.MovePosition(Rigid.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            Rigid.MovePosition(Rigid.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            Rigid.MovePosition(Rigid.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            Rigid.MovePosition(Rigid.position + Vector2.down);

    }
}
