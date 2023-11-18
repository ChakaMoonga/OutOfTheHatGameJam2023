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

    // main menu ***
    public GameObject mainMenuTitle;
    public GameObject mainMenuPanel;
    public GameObject mainPlay;
    public GameObject mainControls;
    public GameObject mainCredits;
    public GameObject mainControlsPanel;
    public GameObject mainCreditsPanel;
    public GameObject mainBackButton;
    public GameObject mainNextButton;
    public GameObject mainBG;

    void Awake()
    {
        instance = this;
        //Hide();
        gameIsPaused = true;
        ShowMainMenu();
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
        mainControlsPanel.SetActive(false);
        mainCreditsPanel.SetActive(false);
        mainNextButton.SetActive(false);
        mainBackButton.SetActive(false);
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

        //cleanup
        mainMenuTitle.SetActive(false);
        mainMenuPanel.SetActive(false);
        mainPlay.SetActive(false);
        mainControls.SetActive(false);
        mainCredits.SetActive(false);
        mainControlsPanel.SetActive(false);
        mainCreditsPanel.SetActive(false);
        mainBackButton.SetActive(false);
        mainNextButton.SetActive(false);
        mainBG.SetActive(false);
}
}
