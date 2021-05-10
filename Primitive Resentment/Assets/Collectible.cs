using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public ItemObject item;
    public InventoryObject inventory;
    public GameObject buttonBlocker;

    public void OnMouseDown()
    {
        if (!buttonBlocker.activeInHierarchy)
        {
            var item = GetComponent<Collectible>();
            if (item)
            {
                Debug.Log("Collected item");
                inventory.AddItem(item.item, 1);
                Destroy(gameObject);
            }
        }
    }
}
