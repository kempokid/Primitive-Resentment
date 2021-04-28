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

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        if(invDisplay.displayName == requiredItem)
        {
            Debug.Log("Correct Item");
            dialogueManager.Start_Dialogue(itemDialogue);
        }
        else
        {
            Debug.Log("Incorrect Item");
            dialogueManager.Start_Dialogue(noItemDialogue);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
