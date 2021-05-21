using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerForAftermathFuck : MonoBehaviour
{

    [Header("Time Variable")]
    public float startingTime = 20f;
    //Public for debugging
    public float totalTime;

    public GameObject fade;


    // Start is called before the first frame update
    void Start()
    {
        fade.SetActive(false);
        totalTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;

        if (totalTime < 0f)
        {
            totalTime = 0f;
        }



        if (totalTime <= 0f)
        {
            totalTime = 0f;
            TimerEvent();
        }
    }
    public void TimerEvent()
    {
        fade.SetActive(true);
    }

}
