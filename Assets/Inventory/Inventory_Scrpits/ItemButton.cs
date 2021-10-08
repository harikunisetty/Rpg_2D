using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButton : MonoBehaviour
{
    public int button;
    public InventoryItem thisItem;
    public InventoryItem GetThisItem()
    {
        for (int i = 0; i < InventoryManager.Instance.items.Count; i++)
        {
            if (button == 1)
            {
                thisItem = InventoryManager.Instance.items[i];
            }
        }
        return thisItem;
    }
    public void CloseButton()
    {

        InventoryManager.Instance.RemoveItem(GetThisItem());
    }
}
   

