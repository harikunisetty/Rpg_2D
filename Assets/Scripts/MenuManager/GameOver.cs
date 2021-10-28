using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver :Menu<GameOver>
{
    [SerializeField] int mainMenuBuildIndex = 1;
    public void Restart()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadMainMenu()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(mainMenuBuildIndex);

        MainMenu.Open();
    }
}
