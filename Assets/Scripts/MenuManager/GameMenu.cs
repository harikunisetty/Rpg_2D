using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu :Menu<GameMenu>
{
    [Header("Score")]
    [SerializeField] Text scoreText;

    public void PauseGamemenu()
    {
        Time.timeScale = 0f;
        PauseMenu.Open();
    }
}
