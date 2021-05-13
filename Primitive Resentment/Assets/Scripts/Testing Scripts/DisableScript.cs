using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableScript : MonoBehaviour
{
    public List<GameObject> DisableList;
    public List<GameObject> EnableList;

    //public void Disable()
    //{
    //    foreach (var obj in DisableList)
    //    {
    //        obj.SetActive(false);
    //    }
    //}

    //public void Enable()
    //{
    //    foreach (var obj in EnableList)
    //    {
    //        obj.SetActive(true);
    //    }
    //}

    public void EnableDisable()
    {
        foreach (var obj in EnableList)
        {
            obj.SetActive(true);
        }

        foreach (var obj in DisableList)
        {
            obj.SetActive(false);
        }
    }
}
