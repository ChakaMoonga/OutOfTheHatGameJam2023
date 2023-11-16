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

}
