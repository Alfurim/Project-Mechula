using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene("Main Menu");

    }
    public void QuitGame()
    {

        Application.Quit();
    }
}