using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnAwake : MonoBehaviour
{
    public Dialogue_Manager dialogueManager;
    public SO_Convo dialogueToPlay;
    float timeRemaining = 0.5f;
    public Object objectToDestroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Dialogue Trigger");
            dialogueManager.Start_Dialogue(dialogueToPlay);
            Destroy(objectToDestroy);
        }
    }
}
