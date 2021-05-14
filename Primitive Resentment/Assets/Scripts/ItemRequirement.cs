using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRequirement : MonoBehaviour
{
    //public string requiredItem;
    public ItemObject requiredItem;
    public SO_Convo noItemDialogue;
    public SO_Convo itemDialogue;
    public SO_Convo postItemDialogue;
    public Dialogue_Manager dialogueManager;
    public InventoryObject inventory;
    //public InventoryDisplay invDisplay;
    //public InventoryManager invManager;
    bool gaveItem = false;
    public bool canAddItem;
    public ItemObject itemToAdd;
    public GameObject objectToChange;
    public GameObject objectToChange2;

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

        if (objectToChange2.activeSelf == false)
        {
            objectToChange2.SetActive(true);
        }
        else
        {
            objectToChange2.SetActive(false);
        }
    }


    // Start is called before the first frame update
    public void TriggerDialogue()
    {
       if (gaveItem == true)
       {
            Debug.Log("Triggered post item dialogue");
            dialogueManager.Start_Dialogue(postItemDialogue);
            return;
       }

       if(requiredItem == null)
       {
            if (canAddItem == true)
            {
                gaveItem = true;
            }
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
                    if (canAddItem == true && gaveItem == false)
                    {
                        Debug.Log("Give item");
                        inventory.AddItem(itemToAdd, 1);
                        gaveItem = true;
                    }
                    ToggleItem();                  
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
