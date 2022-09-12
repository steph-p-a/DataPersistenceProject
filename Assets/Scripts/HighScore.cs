using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class HighScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text highScoreText = GetComponent<Text>();
        if (GameManager.Instance != null)
        {
            highScoreText.text = "High Score: " + GameManager.Instance.highScorePlayerName + " " + GameManager.Instance.highScore;
        }
    }
}
