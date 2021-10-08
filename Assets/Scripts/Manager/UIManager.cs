using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] Image AiHealthFill;
   

    public void Awake()
    {
        if(Instance!=null)
        {
            DestroyImmediate(this.gameObject);
        }
        Instance = this;
    }
    void Start()
    {
        
    }

    public void AiHealthUI(float value)
    {
        AiHealthFill.fillAmount = value * 0.01f;
    }
}
