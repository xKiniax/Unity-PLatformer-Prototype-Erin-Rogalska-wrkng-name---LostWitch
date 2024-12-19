using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui_controller : MonoBehaviour
{
    public void OnStartButton()
    {
        SceneManager.LoadScene("Play");
        Debug.Log("Start pressed");
    }
    public void OnQuitButton()
    {
        Debug.Log("Quit pressed");
        Application.Quit();
        
    }
}
