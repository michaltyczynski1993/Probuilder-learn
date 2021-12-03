using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausedMenu : MonoBehaviour
{
  public FirstPersonController first;
  public GameObject pauseMenu;
  private bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if (isPaused)
            {
                isPaused = false;
                Resume();
            }
            else
            {
                isPaused = true;
                Pause();
            }
        }
    }

    public void Pause()
    {
        //zablokuj kamerę, zablokuj auto corsshair, pokaż kursor, pokaz pause menu, zablokuj ruch gracza
        first.cameraCanMove = false;
        first.lockCursor = false;
        first.crosshair = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        first.playerCanMove = false;
        first.enableJump = false;
        pauseMenu.SetActive(true);
    }
    public void Resume ()
    {
        first.cameraCanMove = true;
        first.lockCursor = true;
        first.crosshair = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        first.playerCanMove = true;
        first.enableJump = true;
        pauseMenu.SetActive(false);
    }
}
