using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modulo3_Homework : MonoBehaviour
{
    [Header("Valor")]
    [SerializeField] float valorTotal = 235.5f;

    // Start is called before the first frame update
    void Start()
    {
        // para parte inteira

        float valor = valorTotal;

        // calcula qnt de notas de 200
        valor = Iteracao(valor, 200);

        // calcula qnt de notas de 100
        valor = Iteracao(valor, 100);

        // calcula qnt de notas de 50
        valor = Iteracao(valor, 50);

        // calcula qnt de notas de 20
        valor = Iteracao(valor, 20);

        // calcula qnt de notas de 10
        valor = Iteracao(valor, 10);

        // calcula qnt de notas de 5
        valor = Iteracao(valor, 5);

        // calcula qnt de notas de 2
        valor = Iteracao(valor, 2);

        // calcula qnt de notas de 1
        valor = Iteracao(valor, 1);

        // parte decimal
        int cent = (int)(valor * 100);

        // calcula qnt de moedas de 50
        cent = Interacao_int(cent, 50);

        // calcula qnt de moedas de 25
        cent = Interacao_int(cent, 25);

        // calcula qnt de moedas de 10
        cent = Interacao_int(cent, 10);

        // calcula qnt de moedas de 5
        cent = Interacao_int(cent, 5);

        // calcula qnt de moedas de 1
        cent = Interacao_int(cent, 1);
    }

    // calculo da quantidade da moeda de valor "nota"
    // retorna o restante de centavos "cent"
    int Interacao_int(int cent, int nota)
    {
        int temp = cent;
        int qtdNotas = Calc_div(temp, nota);
        Debug.Log("Moedas de " + nota + " = " + qtdNotas);
        return cent % nota;
    }

    // calculo da quantidade da nota de valor "nota"
    // retorna o restante do valor
    float Iteracao(float valor, int nota)
    {
        int temp = (int)valor;
        int qtdNotas = Calc_div(temp, nota);
        Debug.Log("Notas de " + nota + " = " + qtdNotas);
        return valor % nota;
    }

    // Calcula o resto da divisao n/t
    int Calc_mod(int n,  int t)
    {
        return n % t;
    }
    
    // Calcula a divisao n/t
    int Calc_div(int n, int t)
    {
        return n / t;
    }
}
