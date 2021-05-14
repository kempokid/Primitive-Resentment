using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class Dialogue_Manager : MonoBehaviour
{
    [Header("Dialogue Variables")]
    public GameObject dialoguePanel;
    public GameObject buttonBlocker;
    public TextMeshProUGUI npcNameText;
    public TextMeshProUGUI dialogueText;
    public Image CharPortrait;
    public GameObject CharacterPortrait;
    
        [Header("Deleting Variables")]
    public bool delete;
    public GameObject objectToDelete;
    public GameObject linkedItem;

    private List<string> conversation;
    private int convoIndex;

    void Start()
    {
        //Sets variables so testing doesn't break anything
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


    //Sets portrait, NPC name, activates button blocker, and initiates conversation, is fed by Scriptable Objects
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

    //Sets default image in dialogue box to a portrait
    public void SetPortrait(SO_Convo _convo)
    {
        //CharPortrait.GetComponent<Image>().sprite = _convo.portrait;

        CharPortrait = CharacterPortrait.GetComponent<Image>();
        CharPortrait.sprite = _convo.portrait;
    }


    //Stops conversations, and reverts back to normal gameplay
    public void Stop_Dialogue()
    {
        buttonBlocker.SetActive(false);
        dialoguePanel.SetActive(false);
        if(delete == true)
        {
            deleteMe();
        }
    }


    //Sets dialogue box text to display text. Called in startDialogue function.
    private void ShowText()
    {
        dialogueText.text = conversation[convoIndex];
    }


    //Advances dialogue. Only needed by dialogue box
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


    //Button function, set in inspector. When activated, tags the button pressed to be deleted, and the linked item, which must have a DisableScript attached to it.
    public void deleteThis(DisableScript _disable)
    {
        objectToDelete = EventSystem.current.currentSelectedGameObject;
        linkedItem = _disable.gameObject;
        delete = true;
    }


    //Function that destroys button that activates it, and a single linked item, after conversation ends. Only activated if the deleteThis function is triggered.
    public void deleteMe()
    {
        Destroy(objectToDelete);
        Destroy(linkedItem);
    }

}
