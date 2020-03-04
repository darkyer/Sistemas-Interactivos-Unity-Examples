using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public int[] arreglo = new int[10]; // variable de tipo Int pero es un arreglo por los "[]" significa que esta variable va a tener 10 ints

    void Start()
    {
        arreglo[0] = 1; // para acceder o asignar valores al arreglo se usa el nombre de la variable y los corchetes con el index de la posición en el arreglo
                        // los arreglos van de 0 hasta el valor definido

        Debug.Log("arreglo[0]= " + arreglo[0]); // este código va a imprimir el valor del arreglo en la posición 0 que se acaba de definir como "1"
    }

}
