using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenMove : MonoBehaviour
{
    public Rigidbody2D Rigid;
    
    void Start()
    {
        
    }

    
    void Update()
    {

        // Input for movement
        if (Input.GetKeyDown(KeyCode.RightArrow))
            Rigid.MovePosition(Rigid.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            Rigid.MovePosition(Rigid.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            Rigid.MovePosition(Rigid.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            Rigid.MovePosition(Rigid.position + Vector2.down);

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // If you get hit by a object with the tag car you would lose.
        if(col.tag == "Car")
        {
            //Make it Zero when you lose
            Score.WinCount = 0;
            // Restart game after losing
            
            SceneManager.LoadScene("ChickenFeet");
        }
    }
}
