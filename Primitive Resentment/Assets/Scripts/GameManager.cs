using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Animation fadeOut;
    public GameObject fadeScreen;
    private AnimationClip fadeOutClip;

    private void Start()
    {
        fadeOut = fadeScreen.GetComponent<Animation>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            fadeOut.Play("Fade Out");
        }
    }

    public void NextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
