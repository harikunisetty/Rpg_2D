using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIManager : MonoBehaviour
{
    [SerializeField] GameObject inventoryMenu; 

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
            if (InventoryManager.Instance.isPaused)
            {
                Resume();
            }
            else
                Pause();
        }
    }
    private void Resume()
    {
        inventoryMenu.gameObject.SetActive(false);
        Time.timeScale = 0.2f;
    }
    private void Pause()
    {
        inventoryMenu.gameObject.SetActive(true);
        Time.timeScale =0.0f;
    }
}
