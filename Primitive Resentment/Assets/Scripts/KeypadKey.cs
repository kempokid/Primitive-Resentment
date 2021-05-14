using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadKey : MonoBehaviour
{
    // Fires off event to KeypadManager. End of script.
    public void KeypadPress()
    {
        FindObjectOfType<KeypadManager>().PressKeypad();
    }
}
