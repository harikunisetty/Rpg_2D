using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour
{
    [SerializeField] int mainMenuBuildIndex = 3;

    public void PlayButton()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.LoadNextLevel();
        }
    }

    public void Restart()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

       /* base.BackButton();*/
    }
    public void LoadMainMenu()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(mainMenuBuildIndex);

        MainMenu.Open();
    }
}
