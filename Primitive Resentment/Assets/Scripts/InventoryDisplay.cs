using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryDisplay : MonoBehaviour
{
    public InventoryManager invManager;
    public TextMeshProUGUI displayText;
    void Start()
    {
        displayText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        string displayName;
        if(invManager.itemHeld != null)
        {
            displayName = invManager.itemHeld.itemName;
        }
        else
        {
            displayName = "none";
        }
        displayText.text = "Item Held: " + displayName;
    }
}
