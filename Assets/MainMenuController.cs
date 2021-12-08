using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Credits(){}
    public void Controls(){}
    public void GameExit()
    {
        Application.Quit();
    }
}
