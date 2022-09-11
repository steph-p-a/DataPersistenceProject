using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton.interactable = false;
    }

    public void NameEntered (string playerName)
    {
        startButton.interactable = true;
    }

    public void StartButtonClicked()
    {
        SceneManager.LoadScene(1);
    }
}
