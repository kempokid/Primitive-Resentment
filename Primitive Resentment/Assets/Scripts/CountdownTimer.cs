using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    [Header("Time Variable")]
    public float startingTime = 80f;
    //Public for debugging
    public float totalTime;

    [Header("Dialogue Options")]
    public Dialogue_Manager dialogueManager;
    public SO_Convo myConvo;

    [Header("Door Blockers")]
    public GameObject doorBlockRight;
    public GameObject doorBlockLeft;

    private float minutes;
    private float seconds;

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

        minutes = (int)(totalTime / 60);
        seconds = (int)(totalTime % 60);



        if(minutes <= 0f && seconds <= 0)
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
}
