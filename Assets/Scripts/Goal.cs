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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
