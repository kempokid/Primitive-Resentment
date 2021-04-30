using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestButtons : MonoBehaviour
{
    public GameObject textBox;
    void Start()
    {
        textBox.SetActive(false);
    }

    void Update()
    {
        
    }

    void SitDown()
    {
        textBox.SetActive(true);
    }
}
