using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool pause;
    public GameObject pauseMenu;
    public GameObject inGameUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }
    public void Pause()
    {
        pause = !pause;
        pauseMenu.SetActive(pause);
        if (pause)
        {
            Time.timeScale = 0;
            Cursor.lockState= CursorLockMode.None;
            Cursor.visible = true;
            inGameUI.SetActive(false);
        }
       
        else
        {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            inGameUI.SetActive(true);
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

}
