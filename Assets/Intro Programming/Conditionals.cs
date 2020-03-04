using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public int varA = 0;// variable pública de tipo int (solo números enteros)
    public int varB = 0;// variable pública de tipo int (solo números enteros)
    
    void Start()
    {

        if (varA > varB) // if que compara si varA es mayor que varB si es verdadero, ejecuta el código debajo
        {
            Debug.Log("varA > varB");
        }
        else if (varA == varB) // si no es verdadero el primer if, compara este segundo if
        {
            Debug.Log("varA = varB");
        }
        else // si ninguno de los dos if anteriores es verdadero ejecuta este código
        {
            Debug.Log("varA < varB");
        }
        
        // notas: en este caso se usó "else if" y "else" pero pueden ser 3 if's diferentes, sin embargo dependiendo de la situación es bueno usar else if para cubrir todos los casos posibles


    }
}
