using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : Menu<MainMenu>
{
    public void PlayButton()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.LoadNextLevel();
        }
    }

    public void SettingButton()
    {
        SettingsMenu settings = transform.parent.Find("SettingsMenu(Clone)").GetComponent<SettingsMenu>();
        if (MenuManager.Instance != null && settings != null)
        {
            Debug.Log("Setting Button Pressed");
            MenuManager.Instance.OpenMenu(settings);
        }
    }

    public void CreditButton()
    {
        CreditsMenu credits = transform.parent.Find("CreditsMenu(Clone)").GetComponent<CreditsMenu>();
        if (MenuManager.Instance != null && credits != null)
        {
            MenuManager.Instance.OpenMenu(credits);
        }
    }

    public override void BackButton()
    {
        Application.Quit();
    }
}
