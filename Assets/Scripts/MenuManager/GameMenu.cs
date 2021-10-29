using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu :Menu<GameMenu>
{
    public void PauseGamemenu()
    {
        Time.timeScale = 0f;
        PauseMenu.Open();
    }
}
