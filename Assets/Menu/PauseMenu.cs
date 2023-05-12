using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool pause;
    public GameObject pauseMenu;

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
        }
       
        else
        {
            Time.timeScale = 1;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

}
