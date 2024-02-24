using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public Button tryAgain;
    public Button End;
    public Button EndGame;

    public Button Credits;
    
    void Start()
    {
        // Add a listener to the first button for when the button is clicked
        tryAgain.onClick.AddListener(OnButton1Click);

        // Add a listener to the second button for when the button is clicked
        End.onClick.AddListener(OnButton2Click);

        EndGame.onClick.AddListener(OnButton3Click);

        Credits.onClick.AddListener(OnButton4Click);
    }

    void OnButton1Click()
    {
       
        SceneManager.LoadScene("Scene1");
    }

    void OnButton2Click()
    {
        
        SceneManager.LoadScene("Start");
    }

    void OnButton3Click()
    {
        Application.Quit();
    }

    void OnButton4Click()
    {
        SceneManager.LoadScene("Credits");
    }
}