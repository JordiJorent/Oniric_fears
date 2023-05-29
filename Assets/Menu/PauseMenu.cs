using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool pause;
    public GameObject pauseMenu;
    public GameObject inGameUI;
    private void Awake()
    {
        pause = false;
    }

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
            EntrarMenuDePausa();
        }       
        else
        {
            SalirMenuDePausa();
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void EntrarMenuDePausa()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        inGameUI.SetActive(false);
    }
    public void SalirMenuDePausa()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        inGameUI.SetActive(true);
    }
    public void SalirAlMenuInicial()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        inGameUI.SetActive(false);
        SceneManager.LoadScene("Menú_inicial 1");
    }

}
