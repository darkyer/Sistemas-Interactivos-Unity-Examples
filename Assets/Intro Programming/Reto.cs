using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Result: "+ RetoMethod(3, 4, 2));
    }

    public int RetoMethod(float a, float b, float c)
    {
        float sumaAB = a + b;
        float multiBC = b * c;

        if(sumaAB > multiBC)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
}
