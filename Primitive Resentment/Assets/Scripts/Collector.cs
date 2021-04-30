using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public InventoryManager invManager;
    //public List<Item> myItems = new List<Item>();
    public Item myItem;

    // Start is called before the first frame update


    public void Interact()
    {
        invManager.itemsHeld.Add(myItem/*invManager.itemGrabbed*/); //= myItem;
        invManager.invDisp.UpdateDisplay();
    }

    void OnMouseDown()
    {
        Interact();
    }

}
