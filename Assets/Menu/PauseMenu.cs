using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool pause;
    public GameObject pauseMenu;
    public GameObject inGameUI;
    private SettingsManager sM;
    private void Awake()
    {
        sM = GameObject.Find("SettingsManager").GetComponent<SettingsManager>();
        inGameUI = GameObject.Find("CrosshairAndStamina");
        
    }
    IEnumerator WaitToHideUI(float s)
    {
        yield return new WaitForSeconds(s);
        pauseMenu.SetActive(false);
        pause = false;
    }
    private void Start()
    {
        sM.Resolutions();
        Debug.Log("Reached start of pause Menu");
        StartCoroutine(WaitToHideUI(.25f));
        Debug.Log("Reached end of pause Menu start()");
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
        pause = false;
        inGameUI.SetActive(false);
        pauseMenu.SetActive(true);
    }
    public void SalirMenuDePausa()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        inGameUI.SetActive(true);
        pauseMenu.SetActive(false);
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
