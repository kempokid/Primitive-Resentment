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

}
