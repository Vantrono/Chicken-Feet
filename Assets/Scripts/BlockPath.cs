using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlockPath : MonoBehaviour

{
    private void OnTriggerEnter2D(Collider2D col)
    {
        // If the Chicken tag hits the sides of the screen it will restart the game but no point lost for score.
        if (col.tag == "Chicken")

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}