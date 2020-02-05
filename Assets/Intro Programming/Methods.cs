using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{

    public int varA = 0;
    public int varB = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("A + B =" + Suma(varA, varB));
    }

    public int Suma(int a, int b)
    {
        return a + b;
    }
}
