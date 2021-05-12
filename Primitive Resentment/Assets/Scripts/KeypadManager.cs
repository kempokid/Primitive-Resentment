using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadManager : MonoBehaviour
{

    public int maxPress;
    public int currentPress;
    public TextMeshProUGUI KeypadDisplay;

    // Start is called before the first frame update
    void Start()
    {
        KeypadDisplay.text = null;
        maxPress = 5;
        currentPress = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PressKeypad()
    {
        if(currentPress < maxPress)
        {
            currentPress++;
        } 

        if(currentPress == 1)
        {
            KeypadDisplay.text = "*";
        }

        if (currentPress == 2)
        {
            KeypadDisplay.text = "**";
        }

        if(currentPress == 3)
        {
            KeypadDisplay.text = "***";
        }

        if(currentPress == 4)
        {
            KeypadDisplay.text = "****";
        }
        
        if (currentPress == maxPress)
        {
            RTS();
            KeypadDisplay.text = null;
            currentPress = 0;
        }
    }
    public string[] randomText;
    public TextMeshProUGUI insultDisplay;


    public void RTS()
    {
        insultDisplay.text = GetRandomText();
    }

    string GetRandomText()
    {
        int random = UnityEngine.Random.Range(0, randomText.Length);
        return randomText[random];
    }
}
