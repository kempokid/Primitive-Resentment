using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    //public static InventoryManager ins;
    public InventoryDisplay invDisp;

    public PlaceHolderItem itemGrabbed = null;
    public List<PlaceHolderItem> itemsHeld = new List<PlaceHolderItem>();
}
