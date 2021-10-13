using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [Header("LevelIndex")]
    [SerializeField] int nextLevelIndex;
    [SerializeField] string nextLevelName;
    [SerializeField] LevelChangerObject levelObject;
    [SerializeField] PlayerMovement playerController;
    [SerializeField] GameObject player;

    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(this.gameObject);
            return;
        }
        else
        {
            Instance = this; 
        }
    }
    void Start()
    {
        levelObject = Object.FindObjectOfType<LevelChangerObject>();    
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "MainUI")
            return;
        if (levelObject != null && levelObject.IsObjectiveCompleted)
        {
            LevelEnded();
        }
    }
    void LevelEnded()
    {
        if (playerController != null)
        {
       
            playerController.enabled = false;

            player.GetComponent<Rigidbody2D>().MovePosition(Vector3.zero);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
                                                                                                                                                                                                                                                                               
            LoadNextLevel();
        }
    }
    public void LoadNextLevel()
    {
      
        int nextLevelIndex = (SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings;

        LoadNextLevel(nextLevelIndex);
    }
    public void LoadNextLevel(int index)
    {
        if (index > 0 && index <= SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(index);
        }
    }

    public void LoadNextLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
