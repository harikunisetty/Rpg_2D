using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Item",fileName ="New Item")]
public class InventoryItem : ScriptableObject
{
    public string itemName;
    public string itemDes;

    public Sprite itemSprite;
    public int itemPrice;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
