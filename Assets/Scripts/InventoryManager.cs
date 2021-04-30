using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    //public static InventoryManager ins;
    public InventoryDisplay invDisp;

    public Item itemGrabbed = null;
    public List<Item> itemsHeld = new List<Item>();
}
