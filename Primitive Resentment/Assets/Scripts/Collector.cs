using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public InventoryManager invManager;
    public Item myItem;

    // Start is called before the first frame update


    public void Interact()
    {
        invManager.itemHeld = myItem;
        invManager.invDisp.UpdateDisplay();
    }

    void OnMouseDown()
    {
        Interact();
    }

}
