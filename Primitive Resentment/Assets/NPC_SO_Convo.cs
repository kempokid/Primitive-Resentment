using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_SO_Convo : MonoBehaviour
{

    public Dialogue_Manager dialogueManager;
    public SO_Convo myConvo;

    private void Start()
    {
        dialogueManager.Start_Dialogue(myConvo);
    }

    //dialogueManager.Start_Dialogue(myConvo);

}
