using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicional : MonoBehaviour
{
    [SerializeField] int number;
    // Start is called before the first frame update
    void Start()
    {
        if(number == 0)
        {
            Debug.Log("O numero eh 0");
        }
        if (number > 0)
        {
            Debug.Log("O numero eh maior que 0");
        }
        if (number < 0)
        {
            Debug.Log("O numero eh menor que 0");
        }

        if(number % 2 == 0)
        {
            Debug.Log("O numero eh par");
        }else
        {
            Debug.Log("O numero eh impar");
        }

        // Operado logico AND
        if(number % 2 == 0 && number > 0)
        {
            Debug.Log("O numero eh par E maior que 0");
        }
        else
        {
            Debug.Log("O numero eh impar ou menor que 0");
        }

        // Operador Logico OR
        if( number % 2 == 0 || number > 0)
        {
            Debug.Log("O numero eh par OU maior que 0");
        }
        else
        {
            Debug.Log("O numero eh impar e menor que 0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
