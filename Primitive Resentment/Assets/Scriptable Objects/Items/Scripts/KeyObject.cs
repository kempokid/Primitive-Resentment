using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Key Item", menuName = "Inventory System/Items/Key")]
public class KeyObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Key;
    }
}
