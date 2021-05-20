using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    [Header("Time Variable")]
    public float startingTime = 60f;
    //Public for debugging
    public float totalTime;
    public int timesFailed;

    [Header("Dialogue Options")]
    public Dialogue_Manager dialogueManager;
    public SO_Convo myConvo;

    [Header("Door Blockers")]
    public GameObject doorBlockRight;
    public GameObject doorBlockLeft;

    // Start is called before the first frame update
    void Start()
    {
        totalTime = startingTime;
        doorBlockLeft.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;

        if(totalTime < 0f)
        {
            totalTime = 0f;
        }



        if(totalTime <= 0f && timesFailed >= 4)
        {
            totalTime = 0f;
            TimerEvent();
        }
    }

    public void TimerEvent()
    {
        //Trigger monkey dialogue
        {
            dialogueManager.Start_Dialogue(myConvo);
        }

        //Open door
        Destroy(doorBlockRight);

        //Destroy time manager
        Destroy(gameObject);
    }

    public void FailureIncrease()
    {
        timesFailed++;
    }
}
