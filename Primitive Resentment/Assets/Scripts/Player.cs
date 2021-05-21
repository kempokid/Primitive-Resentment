using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InventoryObject inventory;
    public Collectible collectible;

    private void OnApplicationQuit()
    {
        inventory.Container.Clear();
    }

    private void Awake()
    {
        inventory.Container.Clear();
    }


}
