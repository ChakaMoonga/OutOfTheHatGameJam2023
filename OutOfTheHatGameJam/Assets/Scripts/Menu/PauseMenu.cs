using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static PauseMenu instance;
    public static bool gameIsPaused;

    public GameObject mainMenu;
    public GameObject pauseMenu;

    void Awake()
    {
        instance = this;
        Hide();
        gameIsPaused = false;
    }

    public void Show()
    {
        ShowPauseMenu();
        gameObject.SetActive(true);
        gameIsPaused = true;
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void ResumeGame()
    {
        Hide();
        gameIsPaused = false;
    }

    public void SwitchMenu (GameObject someMenu)
    {
        //clean up
        mainMenu.SetActive(false);
        pauseMenu.SetActive(false);

        //turn on
        someMenu.SetActive(true);
    }

    public void ShowMainMenu()
    {
        SwitchMenu(mainMenu);
    }

    public void ShowPauseMenu()
    {
        SwitchMenu(pauseMenu);
    }

    public void RestartGame()
    {
        //reload scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Hide();
        gameIsPaused = false;
    }
}
