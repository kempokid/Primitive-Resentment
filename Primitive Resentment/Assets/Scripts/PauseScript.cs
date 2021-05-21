using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    //The main scene decided the pause menu didn't fucking work because its a load of dog shit so all this code is fucking worthless

    //public GameObject BaseCanvas;
    //public GameObject PauseCanvas;

    //bool isPaused = false;

    //private void Start()
    //{
    //    PauseCanvas.SetActive(false);

    //}


    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown("escape"))
    //    {           
    //        isPaused = !isPaused;
    //    }

    //    if (isPaused)
    //    {
    //        BaseCanvas.SetActive(false);
    //        PauseCanvas.SetActive(true);
    //    }
    //    else
    //    {
    //        BaseCanvas.SetActive(true);
    //        PauseCanvas.SetActive(false);
    //    }
    //}

    //public void Resume()
    //{
    //    BaseCanvas.SetActive(true);

    //    PauseCanvas.SetActive(false);

    //    isPaused = !isPaused;
    //}

    //public void quit()
    //{
    //    Application.Quit();
    //}

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

}
