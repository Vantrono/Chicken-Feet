using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Counting how many times won
    public static int WinCount = 0;

    public Text ScoreText;

    private void Start()
    {
        // Saving score
        ScoreText.text = WinCount.ToString();
    }
}
