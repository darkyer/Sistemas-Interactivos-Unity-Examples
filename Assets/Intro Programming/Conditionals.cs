using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public int varA = 0;
    public int varB = 0;
    // Start is called before the first frame update
    void Start()
    {

        if (varA > varB)
        {
            Debug.Log("varA > varB");
        }
        else if (varA == varB)
        {
            Debug.Log("varA = varB");
        }
        else
        {
            Debug.Log("varA < varB");
        }
        
    }
}
