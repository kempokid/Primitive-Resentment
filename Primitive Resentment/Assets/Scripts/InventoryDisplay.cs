﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryDisplay : MonoBehaviour
{
    public InventoryManager invManager;
    public TextMeshProUGUI displayText;
    
    [HideInInspector]
    public string displayName;
    void Start()
    {
        displayText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        
        if(invManager.itemsHeld != null)
        {
            //foreach(var )
            displayName = invManager.itemGrabbed.itemName;
        }
        else
        {
            displayName = "none";
        }
        displayText.text = "Item Held: " + displayName;
    }
}
