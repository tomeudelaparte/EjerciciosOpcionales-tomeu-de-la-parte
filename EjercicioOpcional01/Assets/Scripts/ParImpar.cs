using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParImpar : MonoBehaviour
{
    // Var tipo Int para guardar un valor
    private int num;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Comprueba si la tecla ENTER es pulsada
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // NUM guarda el contenido del InputField parseado a Int
            num = int.Parse(GetComponent<InputField>().text);

            // Llama a la función con NUM como Input
            EsParImpar(num);
        }
    }

    // Función que comprueba si un número es par o impar
    public void EsParImpar(int num)
    {
        // Comprueba si num es par y lo indica por consola.
        if (num % 2 == 0)
        {
            Debug.Log($"El número {num} es par");
        }

        // Si NO es par, lo indica por consola.
        else
        {
            Debug.Log($"El número {num} es impar");
        }
    }
}
