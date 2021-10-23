using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiScore : MonoBehaviour
{
    public static UiScore Instance;
    [SerializeField] Text coinsCountText;
    [SerializeField] Text killCountText;
    void Start()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
            return;
        }
        else
            Instance = this;
        coinsCountText.text = "00";
     
    }
   public void CoinsCountUI()
    {
        coinsCountText.text = "00" +GameManager.Instance.Coins.ToString();
    }
    public void KillCountUI()
    {
        killCountText.text = "00" +GameManager.Instance.Kill1.ToString();
    }
}
