using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    public void OnStartButton_Pressed()
    {
        SceneManager.LoadScene("Main");
    }
    public void OnTutorialButton_Pressed()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void OnMenuButton_Pressed()
    {
        SceneManager.LoadScene("Start");
    }
    public void OnExitButton_Pressed()
    {
        Application.Quit();
    }
}
