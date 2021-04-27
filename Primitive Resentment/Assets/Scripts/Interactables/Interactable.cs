using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interactable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.enabled = false;
    }

    public void Interact()
    {
        Debug.Log("interacting with" + name);
    }
}
