using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variaveis : MonoBehaviour
{
    [Header("Inteiros")]
    [SerializeField] int number1;
    [SerializeField] int number2 = 5;
    int number3;

    [Header("Floats")]
    [SerializeField] float floatNumber = 0.12345f;

    [Header("String")]
    [SerializeField] string word1 = "Mentorama - ";
    [SerializeField] string word2 = "Curso Unity";
    string word3 = " ao quadrado é: ";

    [Header("Booleanos")]
    [SerializeField] bool boolean = true;

    // tipo especifico para objetos
    [SerializeField] GameObject objeto;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(number1 + number2);

        Debug.Log("A soma é: " + number1 + number2);
        int soma = number1 + number2;
        Debug.Log("A soma é: " + soma);

        Debug.Log(word1 + word2);

        int squarenumber2 = number2 * number2;
        Debug.Log(number2 + word3 + squarenumber2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
