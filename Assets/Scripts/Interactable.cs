﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Interact(); 
    }

    public void Interact()
    {
        Debug.Log("Click haha");
    }
}
