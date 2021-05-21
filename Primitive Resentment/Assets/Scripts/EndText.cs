using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class EndText : MonoBehaviour
{
    public float letterPause = 0.2f;

    string message;
    TextMeshProUGUI textComp;

    // Use this for initialization
    void Start()
    {
        textComp = GetComponent<TextMeshProUGUI>();
        message = textComp.text;
        textComp.text = "";
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        
        foreach (char letter in message)
        {
            textComp.text += letter;
            yield return 0;
            yield return new WaitForSeconds(letterPause);
        }
    }
}
