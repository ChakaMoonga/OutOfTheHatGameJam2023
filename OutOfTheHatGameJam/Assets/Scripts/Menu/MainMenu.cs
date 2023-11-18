using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public static MainMenu instance;

    public GameObject mainMenuPanel;
    public GameObject mainTitle;
    
    // main buttons
    public GameObject mainPlay;
    public GameObject mainControls;
    public GameObject mainCredits;

    // controls menu
    public GameObject controlsList;

    // credits
    public GameObject creditsHeader;
    public GameObject visualTeamList;
    public GameObject codeTeamList;

    // back
    public GameObject backButton;
    public GameObject nextButton;

    void Awake()
    {
        instance = this;
        //PauseMenu.gameIsPaused = true;
        //OnStart();
        Hide();
    }

    void Hide()
    {
        gameObject.SetActive(false);
    }

    void OnStart()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        mainTitle.SetActive(true);
        mainPlay.SetActive(true);
        mainControls.SetActive(true);
        mainCredits.SetActive(true);
    }

    public void ShowControlsMenu()
    {
        controlsList.SetActive(true);
        backButton.SetActive(true);

        //clean up
        mainPlay.SetActive(false);
        mainControls.SetActive(false);
        mainCredits.SetActive(false);
        creditsHeader.SetActive(false);
        visualTeamList.SetActive(false);
        codeTeamList.SetActive(false);
        backButton.SetActive(false);
        nextButton.SetActive(false);
    }

    public void ShowVisualCreditsMenu()
    {
        visualTeamList.SetActive(true);
        creditsHeader.SetActive(true);
        nextButton.SetActive(true);

        backButton.SetActive(true);

        //clean up
        mainPlay.SetActive(false);
        mainControls.SetActive(false);
        mainCredits.SetActive(false);
        codeTeamList.SetActive(false);
        backButton.SetActive(false);
    }

    public void ShowCodeCreditsMenu()
    {
        codeTeamList.SetActive(true);
        backButton.SetActive(true);

        //clean up
        visualTeamList.SetActive(false);
    }

    public void SwitchMenu(GameObject someMenu)
    {
        //clean up
        mainPlay.SetActive(false);
        mainControls.SetActive(false);
        mainCredits.SetActive(false);
        controlsList.SetActive(false);
        visualTeamList.SetActive(false);
        codeTeamList.SetActive(false);
        backButton.SetActive(false);

        //turn on
        someMenu.SetActive(true);
    }
}
