using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteract : MonoBehaviour
{
    private Dialogue_Manager dialogueManager;
    public SO_Convo interactDialogue;
    // Start is called before the first frame update
    void Start()
    {
        dialogueManager = FindObjectOfType<Dialogue_Manager>();
    }

    public void ObjectInteract()
    {
        dialogueManager.Start_Dialogue(interactDialogue);
    }
}
