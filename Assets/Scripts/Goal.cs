using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{

    private void OnTriggerEnter2D()
    {
        // Winning gets 1 point
        Score.WinCount += 1;
        // Restarts after winning
        if (Score.WinCount < 2)
        {
            SceneManager.LoadScene("2nd Level");
        }
        else if (Score.WinCount >= 3)
        {
            SceneManager.LoadScene("3rd Level");
        }
        else 
        {
           SceneManager.LoadScene("ChickenFeet");
        }
        
            
    }


}
