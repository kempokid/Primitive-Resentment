using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
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
    

    

    //In testing
    //private List<GameObject> itemsToDisable;
    //private List<GameObject> itemsToEnable;
    
    public bool delete;
    public GameObject objectToDelete;
    public GameObject linkedItem;

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
        if(delete == true)
        {
            deleteMe();
        }
    }


    //In testing

    //public void DisableItems()
    //{
    //    FindObjectOfType<DisableScript>().Disable();
    //}

    //public void EnableItems()
    //{
    //    //itemsToEnable = _items.ItemsToEnable;

    //    //foreach (var obj in itemsToEnable)
    //    //{
    //    //    obj.SetActive(true);
    //    //}



    //}
    //End of testing


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

    public void deleteThis(DisableScript _disable)
    {
        objectToDelete = EventSystem.current.currentSelectedGameObject;
        linkedItem = _disable.gameObject;
        delete = true;
    }

    public void deleteMe()
    {
        Destroy(objectToDelete);
        Destroy(linkedItem);
    }

}
