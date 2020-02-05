using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int varA = 0;
    int varB = 2;

    // Start is called before the first frame update
    void Start()
    {
        int suma = varA + varB;
        Debug.Log("VarA = " + varA);
        Debug.Log("VarB = " + varB);
        Debug.Log("VarA + VarB = " + varA + varB);
        Debug.Log("VarA + VarB = " + suma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
