using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int varA = 0;    // variable pública de tipo int (solo números enteros)
                            // al ser pública se puede ver en unity y cambiar el valor

    int varB = 2;           // variable privada de tipo int (solo números enteros)
                            // al ser privada NO se puede ver en unity y cambiar el valor

    // función creada por unity automaticamente que se ejecuta 1 sola vez al poner "play"
    void Start()
    {
        int suma = varA + varB; // se crea una nueva variable que solo existe dentro de la función start
                                // esta variable es de tipo int (enteros) y es la suma de las primeras dos variables

        Debug.Log("VarA = " + varA);                // imprime el valor de varA
        Debug.Log("VarB = " + varB);                // imprime el valor de varB
        Debug.Log("VarA + VarB = " + varA + varB);  // imrpime el valor de juntar varA y varB pero no sumados, solo concatenarlos
        Debug.Log("VarA + VarB = " + suma);         // imprime el valor de la variable suma que es la suma de varA y varB 
    }

    // función creada por unity automaticamente que se ejecuta cada frame al poner "play"
    void Update()
    {
        //vacía
    }
}
