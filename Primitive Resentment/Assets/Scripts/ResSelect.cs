using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResSelect : MonoBehaviour
{
    public void Res2160()
    {
        Screen.SetResolution(3840, 2160, true);
        SceneManager.LoadScene("MainMenu");
    }
    public void Res1440()
    {
        Screen.SetResolution(2560, 1440, true);
        SceneManager.LoadScene("MainMenu");
    }
    public void Res1080()
    {
        Screen.SetResolution(1920, 1080, true);
        SceneManager.LoadScene("MainMenu");
    }
    public void Res900()
    {
        Screen.SetResolution(1600, 900, true);
        SceneManager.LoadScene("MainMenu");
    }
    public void Res768()
    {
        Screen.SetResolution(1366, 768, true);
        SceneManager.LoadScene("MainMenu");
    }
    public void Res720()
    {
        Screen.SetResolution(1280, 720, true);
        SceneManager.LoadScene("MainMenu");
        
    }
    
}
