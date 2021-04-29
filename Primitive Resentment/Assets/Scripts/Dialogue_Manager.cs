﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue_Manager : MonoBehaviour
{
    public GameObject dialoguePanel;
    public TextMeshProUGUI npcNameText;
    public TextMeshProUGUI dialogueText;
    public Image CharPortrait;
    public GameObject CharacterPortrait;

    private List<string> conversation;
    private int convoIndex;

    void Start()
    {
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
        dialoguePanel.SetActive(false);
    }

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