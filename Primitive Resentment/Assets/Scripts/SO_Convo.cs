using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class SO_Convo : ScriptableObject
{

    //Scriptable object, called by Dialogue manager.

    public string npcName;
    public Sprite portrait;
    public List<string> myConversation = new List<string>();

    //Item List to enable/Disable after conversation

    //public List<GameObject> ItemsToDisable = new List<GameObject>();
    //public List<GameObject> ItemsToEnable = new List<GameObject>();

}
