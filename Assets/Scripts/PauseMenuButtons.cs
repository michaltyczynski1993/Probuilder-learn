using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtons : MonoBehaviour
{
    public PausedMenu pausedMenu;

    public void Resume()
    {
        pausedMenu.Resume();
    }
    public void Restart()
    {
        pausedMenu.Resume();
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        
    }
    public void MainMenu()
    {
        Debug.Log("Wracam do głównego menu");
    }
}
