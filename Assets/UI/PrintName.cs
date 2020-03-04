using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintName : MonoBehaviour
{
    public void PrintNameButton() // función pública de nombre "PrintNameButton"
    {
        Debug.Log(gameObject.name); // imrpime el nombre del gameObject que tiene el script agregado
    }
}
