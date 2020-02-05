using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Value: 1");
        Debug.Log("Value: 2");
        Debug.Log("Value: 3");
        Debug.Log("Value: 4");
        Debug.Log("Value: 5");
        Debug.Log("Value: 6");
        Debug.Log("Value: 7");
        Debug.Log("Value: 8");
        Debug.Log("Value: 9");
        Debug.Log("Value: 10");

        Debug.Log("---------------------------");

        for (int i=1; i <= 10; i++)
        {
            Debug.Log("Value: " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
