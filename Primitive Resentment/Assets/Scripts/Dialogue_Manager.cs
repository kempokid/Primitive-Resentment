using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue_Manager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public GameObject buttonBlocker;
    public TextMeshProUGUI npcNameText;
    public TextMeshProUGUI dialogueText;
    public Image CharPortrait;
    public GameObject CharacterPortrait;

    //public List<GameObject> itemsToDisable;
    //public List<GameObject> itemsToEnable;

    private List<string> conversation;
    private int convoIndex;

    void Start()
    {
        buttonBlocker.SetActive(false);
        dialoguePanel.SetActive(false);
        
    }

    
    public void Start_Dialogue(string _npcName, List<string> _convo)
    {
        npcNameText.text = _npcName;
        conversation = new List<string>(_convo);
        dialoguePanel.SetActive(true);
        convoIndex = 0;
        ShowText();
    }

    public void Start_Dialogue(SO_Convo _convo)
    {
        SetPortrait(_convo);
        buttonBlocker.SetActive(true);
        npcNameText.text = _convo.npcName;
        conversation = new List<string>(_convo.myConversation);
        dialoguePanel.SetActive(true);
        convoIndex = 0;
        ShowText();
    }

    public void SetPortrait(SO_Convo _convo)
    {
        //CharPortrait.GetComponent<Image>().sprite = _convo.portrait;

        CharPortrait = CharacterPortrait.GetComponent<Image>();
        CharPortrait.sprite = _convo.portrait;
    }

    public void Stop_Dialogue()
    {
        buttonBlocker.SetActive(false);
        dialoguePanel.SetActive(false);
    }

    //public void DisableItems(SO_Convo _items)
    //{
    //    itemsToDisable = _items.ItemsToDisable;

    //    foreach (var obj in itemsToDisable)
    //    {
    //        obj.SetActive(false);
    //    }
    //}

    //public void EnableItems(SO_Convo _items)
    //{
    //    itemsToEnable = _items.ItemsToEnable;

    //    foreach (var obj in itemsToEnable)
    //    {
    //        obj.SetActive(true);
    //    }
    //}

    private void ShowText()
    {
        dialogueText.text = conversation[convoIndex];
    }

    public void Next()
    {
        if (convoIndex < conversation.Count - 1)
        {
            convoIndex += 1;
            ShowText();
        }
        else
        {
            Stop_Dialogue();

        }
    }
}
