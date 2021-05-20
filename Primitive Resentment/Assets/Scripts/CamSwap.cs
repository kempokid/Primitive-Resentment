using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwap : MonoBehaviour
{

    public GameObject nextCam;

    public void camSwap()
    {
        nextCam.SetActive(true);
        gameObject.SetActive(false);
    }
}
