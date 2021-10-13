using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public   enum health
{
    case3 ,case2, case1
}*/
public class GameControl : MonoBehaviour
{
    public GameObject hearth1, hearth2, hearth3;
    public GameObject gameOver;
    public static int health;
    void Start()
    {
        health = 3;
        hearth1.gameObject.SetActive(true);
        hearth2.gameObject.SetActive(true);
        hearth3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
            health = 3;
        switch (health)
        {
            case 3:
                hearth1.gameObject.SetActive(true);
                hearth2.gameObject.SetActive(true);
                hearth3.gameObject.SetActive(true);

                break;
            case 2:
                hearth1.gameObject.SetActive(true);
                hearth2.gameObject.SetActive(true);
                hearth3.gameObject.SetActive(false);

                break;
            case 1:
                hearth1.gameObject.SetActive(true);
                hearth2.gameObject.SetActive(false);
                hearth3.gameObject.SetActive(false);

                break;
            case 0:
                hearth1.gameObject.SetActive(false);
                hearth2.gameObject.SetActive(false);
                hearth3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;
        }

    }
}
