using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuController : MonoBehaviour
{
    public GameObject controlPanel;
    public GameObject controlsFirstSelect, controlsFirstClosed;
    
    public void NewGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Credits(){}
    public void ControlsOpen()
    {
        controlPanel.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(controlsFirstSelect);
    }
    public void ControlsClosed()
    {
        controlPanel.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(controlsFirstClosed);
    }
    public void GameExit()
    {
        Application.Quit();
    }
}
