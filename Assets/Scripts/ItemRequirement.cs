using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRequirement : MonoBehaviour
{
    public string requiredItem;
    public SO_Convo noItemDialogue;
    public SO_Convo itemDialogue;
    public Dialogue_Manager dialogueManager;
    public InventoryDisplay invDisplay;
    public InventoryManager invManager;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        //if(invManager.itemsHeld.Contains(requiredItem))(invDisplay.displayName == requiredItem)
        foreach (var x in invManager.itemsHeld)
        {
            if (x.itemName == requiredItem)
            {
                Debug.Log("Correct Item");
                dialogueManager.Start_Dialogue(itemDialogue);
                return;
            }
            else
            {
                Debug.Log("Incorrect Item");
                dialogueManager.Start_Dialogue(noItemDialogue);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
