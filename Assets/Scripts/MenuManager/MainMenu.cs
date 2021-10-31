using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu :Menu<MainMenu>
{
    [Header("Load Current Play Level")]
    [SerializeField] int loadLevelOne = 1;

    public void PlayButton()
    {
        if(GameManager.Instance != null)
        {
          GameManager.Instance.LoadNextLevel(loadLevelOne);
        }
        GameMenu.Open();
    }
    public void SettingsButton()
    {
        SettingsMenu.Open();
    }
    public void CreditButton()
    {
        CreditsMenu.Open();
    }
    public override void BackButton()
    {
        Application.Quit();
    }
}