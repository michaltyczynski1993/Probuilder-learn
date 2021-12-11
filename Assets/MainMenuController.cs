using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject controlPanel;
    public void NewGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Credits(){}
    public void ControlsShowAndHide()
    {
        if(controlPanel.active == false)
        {
            controlPanel.SetActive(true);
        }
        else 
        {
            controlPanel.SetActive(false);
        }
    }
    public void GameExit()
    {
        Application.Quit();
    }
}
