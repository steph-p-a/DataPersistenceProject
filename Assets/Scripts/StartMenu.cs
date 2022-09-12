using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] Text highScore;    
    [SerializeField] InputField nameInputField;
    [SerializeField] Button startButton;
    [SerializeField] Button quitButton;


    // Start is called before the first frame update
    void Start()
    {
        startButton.interactable = false;
        highScore.text = "High Score: " + GameManager.Instance.highScorePlayerName + " " + GameManager.Instance.highScore;
    }

    public void NameChanged(string unused)
    {        
        if (nameInputField.text.Length > 0)
        { 
            startButton.interactable = true;
            GameManager.Instance.playerName = nameInputField.text;
        }
        else
        {
            startButton.interactable = false;
        }
    }

    public void StartButtonClicked()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButtonClicked()
    {
        GameManager.Instance.SaveQuit();
    }
}
