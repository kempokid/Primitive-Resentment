using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryToggle : MonoBehaviour
{

    public GameObject inventoryScreen;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if(inventoryScreen.activeSelf == true)
            {
                inventoryScreen.SetActive(false);
            }
            else
            {
                inventoryScreen.SetActive(true);
            }
        }
    }
}
