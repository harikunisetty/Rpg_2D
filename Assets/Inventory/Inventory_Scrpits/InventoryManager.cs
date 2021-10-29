using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public bool isPaused;

    public List<InventoryItem> items = new List<InventoryItem>();

    public List<int> itemtNumbers = new List<int>();
    public GameObject[] Slots;
   

    public InventoryItem addItem_01;
    public InventoryItem RemoveItem_01;
    public void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(this.gameObject);
        }
        else
        {
             Instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }
    public void Start()
    {
        DisplayItems();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Additem(addItem_01);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            RemoveItem(RemoveItem_01);
        }
    }
    private void DisplayItems()
    {
        for(int i = 0; i < Slots.Length; i++)
        {
            if (i < items.Count)
            {
                Slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
                Slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;

                Slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 1);
                Slots[i].transform.GetChild(1).GetComponent<Text>().text = itemtNumbers[i].ToString();

                Slots[i].transform.GetChild(2).gameObject.SetActive(true);
            }
            else
            {
                Slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
                Slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;

                Slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 0);
                Slots[i].transform.GetChild(1).GetComponent<Text>().text = null;
                Slots[i].transform.GetChild(2).gameObject.SetActive(false);
            }
        }
    }
    public void Additem(InventoryItem item)
    {
        if (!items.Contains(item))
        {
            items.Add(item);
            itemtNumbers.Add(1);
        }
        else
        {
            Debug.Log("you have alerdy have this one!");
            for(int i=0; i< items.Count; i++)
            {
                if (item== items[i])
                {
                    itemtNumbers[i]++;
                }
            }
        }
        DisplayItems();
    }
    public  void RemoveItem(InventoryItem item)
    {
        if (items.Contains(item))
        {
            for(int i=0; i < items.Count; i++)
            {
                if (item == items[i])
                {
                    itemtNumbers[i]--;
                    if (itemtNumbers[i] == 0)
                    {
                        items.Remove(item);
                        itemtNumbers.Remove(itemtNumbers[i]);
                    }
                }
            }
          
        }
        else
        {
            Debug.Log("There is no" + item + "in My Bags");
        }
        DisplayItems();
    }
}
