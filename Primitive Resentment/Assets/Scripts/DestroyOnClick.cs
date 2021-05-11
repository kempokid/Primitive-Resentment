using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
