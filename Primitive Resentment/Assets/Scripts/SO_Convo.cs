﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class SO_Convo : ScriptableObject
{

    public string npcName;
    public Sprite portrait;
    public List<string> myConversation = new List<string>();
    //public List<GameObject> ItemsToDisable = new List<GameObject>();
    //public List<GameObject> ItemsToEnable = new List<GameObject>();

}
