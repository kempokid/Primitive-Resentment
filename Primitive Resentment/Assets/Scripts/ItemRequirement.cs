using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRequirement : MonoBehaviour
{
    //public string requiredItem;
    public ItemObject requiredItem;
    public SO_Convo noItemDialogue;
    public SO_Convo itemDialogue;
    public Dialogue_Manager dialogueManager;
    public InventoryObject inventory;
    //public InventoryDisplay invDisplay;
    //public InventoryManager invManager;
    bool foundItem = false;
    public GameObject objectToChange;

    void ToggleItem()
    {
        if (objectToChange.activeSelf == false)
        {
            objectToChange.SetActive(true);
        }
        else
        {
            objectToChange.SetActive(false);
        }
    }


    // Start is called before the first frame update
    public void TriggerDialogue()
    {
        if (foundItem == true)
        {
            ToggleItem();
        }
        else if(requiredItem == null)
        {
            dialogueManager.Start_Dialogue(itemDialogue);
            ToggleItem();
        }
        else
        {
            //if(invManager.itemsHeld.Contains(requiredItem))(invDisplay.displayName == requiredItem)
            foreach (var inventorySlot in inventory.Container)
            {
                if (inventorySlot.item == requiredItem)
                {
                    Debug.Log("Correct Item");
                    dialogueManager.Start_Dialogue(itemDialogue);
                    foundItem = true;
                    return;
                }
                else
                {
                    Debug.Log("Incorrect Item");
                    dialogueManager.Start_Dialogue(noItemDialogue);
                }
            }
        }
    }
}
