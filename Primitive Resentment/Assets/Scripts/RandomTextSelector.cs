using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomTextSelector : MonoBehaviour
{
    public string[] randomText;
    public TextMeshProUGUI insultDisplay;


    public void RTS()
    {
        insultDisplay.text = GetRandomText();
    }

    string GetRandomText()
    {
        int random = Random.Range(0, randomText.Length);
        return randomText[random];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
