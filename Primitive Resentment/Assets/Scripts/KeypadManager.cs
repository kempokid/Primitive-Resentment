using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadManager : MonoBehaviour
{

    private int maxPress;
    private int currentPress;
    public TextMeshProUGUI KeypadDisplay;

    // Start is called before the first frame update
    void Start()
    {
        //Starts variables
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
        //Adds each press to current press total, until max value
        if (currentPress < maxPress)
        {
            currentPress++;
        }


        //Checks how many times all buttons have been pressed, returns value to string.
        switch (currentPress)
        {
            case 0:
                KeypadDisplay.text = null;
                break;
            case 1:
                KeypadDisplay.text = "*";
                break;
            case 2:
                KeypadDisplay.text = "**";
                break;
            case 3:
                KeypadDisplay.text = "***";
                break;
            case 4:
                KeypadDisplay.text = "****";
                break;
        }


        //Preforms random generation, then resets current presses back to 0
        if (currentPress == maxPress)
        {
            RTS();
            KeypadDisplay.text = null;
            currentPress = 0;
        }
    }
    public string[] randomText;
    public TextMeshProUGUI insultDisplay;

    //Displays generated text from GetRandomText
    public void RTS()
    {
        insultDisplay.text = GetRandomText();
    }

    //Picks a random value from 0 - Max, and returns its string and feeds to RTS
    string GetRandomText()
    {
        int random = UnityEngine.Random.Range(0, randomText.Length);
        return randomText[random];
    }
}
