using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static PauseMenu instance;

    public GameObject mainMenu;
    public GameObject pauseMenu;

    void Awake()
    {
        instance = this;
    }

    void SwitchMenu (GameObject someMenu)
    {
        //clean up
        mainMenu.SetActive(false);
        pauseMenu.SetActive(false);

        //turn on
        someMenu.SetActive(true);
    }

    void ShowMainMenu()
    {
        SwitchMenu(mainMenu);
    }

    void ShowPauseMenu()
    {
        SwitchMenu(pauseMenu);
    }
}
