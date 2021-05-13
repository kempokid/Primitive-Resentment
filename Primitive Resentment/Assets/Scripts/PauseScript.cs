using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public GameObject BaseCanvas;
    public GameObject PauseCanvas;

    bool isPaused;

    private void Start()
    {
        isPaused = false;
        PauseCanvas.SetActive(false);
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape") && isPaused == false)
        {
            BaseCanvas.SetActive(false);

            PauseCanvas.SetActive(true);
        }

        if(Input.GetKeyDown("escape") && isPaused == true)
        {
            BaseCanvas.SetActive(true);

            PauseCanvas.SetActive(false);
        }
    }

    public void Resume()
    {
        BaseCanvas.SetActive(true);

        PauseCanvas.SetActive(false);
    }

    public void quit()
    {
        Application.Quit();
    }
}
