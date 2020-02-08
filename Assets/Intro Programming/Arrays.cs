using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public int[] arreglo = new int[10];
    // Start is called before the first frame update
    void Start()
    {
        arreglo[0] = 1;
        Debug.Log("arreglo[0]= " + arreglo[0]);
    }

}
