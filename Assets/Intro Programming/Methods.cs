using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Methods : MonoBehaviour
{

    public int varA = 0;    // variable pública de tipo int (solo números enteros)
    public int varB = 0;    // variable pública de tipo int (solo números enteros)
    public Text textoUI;
    public InputField inputA;
    public InputField inputB;

    void Start()
    {
        Debug.Log("A + B =" + Suma(varA, varB)); // se imprime el resultado de la funcion Suma y se le pasa como valor "a" la variable varA y como valor "b" la variable varB y los suma
    }

    public int Suma(int a, int b) // funcion llamada Suma de tipo int(enteros) que requiere 2 valores para ejecutarse (a y b) y regresa la suma de estos dos valores
    {
        return a + b;
    }

    public void SumaUI()
    {
        int varAInput = int.Parse(inputA.text);
        int varBInput = int.Parse(inputB.text);

        Debug.Log(Suma(varAInput, varBInput)); // imprime en consola

        textoUI.text = Suma(varAInput, varBInput).ToString(); // cambia el texto UI
    }
}
