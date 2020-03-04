using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // para imprimir en consola del 1 al 10 se requiere hacer 10 lineas de código o usar un loop
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

        for (int i=1; i <= 10; i++) // un "for" requiere 3 elementos
                                    // 1.- Una variable i con valor 1
                                    // 2.- La condición para ver si se ejecuta el código dentro (i <= 10)
                                    // 3.- El incremento de valor de la variable inicial (i) en este caso es i++ que significa que le suma 1 cada iteración
        {
            Debug.Log("Value: " + i); // dentro del código del "for" podemos acceder a la iteración actual con la variable definida al inicio (i)
        }
    }

    // este for hace lo mismo que los primeros debugs.
}
