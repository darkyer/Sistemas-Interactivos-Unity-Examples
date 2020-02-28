using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintName : MonoBehaviour
{
    public void PrintNameButton()
    {
        Debug.Log(gameObject.name);
    }
}
