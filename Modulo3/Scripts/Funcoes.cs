using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Funcoes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int soma = Sum(3, 5);
        Debug.Log(soma);

        int exponenciacao = Exponencial(3, 3);
        Debug.Log(exponenciacao);
    }

    int Sum(int  n, int k)
    {
        return n + k;
    }

    // Funcao fazendo uso de recursao
    int Exponencial(int  numero, int expoente)
    {
        int resultado = numero;
        if(expoente > 1)
        {
            expoente--;
            resultado = Exponencial(numero, expoente) * numero;
        }
        return resultado;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
