using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIManager : MonoBehaviour
{
    [SerializeField] GameObject inventoryMenu;
    [SerializeField]
    GameObject inventoryBox;
    [SerializeField] static bool GameIsPaused;

    void Start()
    {
        inventoryMenu.gameObject.SetActive(false);
    }

    void Update()
    {
        InventoryControl();
    }
    private void InventoryControl()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
                Pause();
        }

    }
    public void Resume()
    {
        inventoryMenu.gameObject.SetActive(false);
        inventoryBox.gameObject.SetActive(true);
        Time.timeScale = 0.2f;
    }
   public void Pause()
    {
        inventoryMenu.gameObject.SetActive(true);
        inventoryBox.gameObject.SetActive(false);
        Time.timeScale =0.0f;
    }
}
