using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    [SerializeField] int[] numberArray = new int[10];

    int[,] matriz = new int[10,10];
    int[,,] matrizDeArray = new int[10,10,10];

    List<int> numberList = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        numberArray[3] = 5;

        // Loop para percorrer Array
        for(int i = 0;  i < numberArray.Length; i++)
        {
            Debug.Log(numberArray[i]);
        }

        // Loop para percorrer matriz
        for (int i = 0; i < numberArray.Length; i++)
        {
            for(int j = 0; j < numberArray.Length; j++)
            {
                matriz[i, j] = i * 10 + j;
                Debug.Log(matriz[i, j]);
            }
        }

        // Lista
        for(int i = 0;i < 5; i++)
        {
            numberList.Add(i);
        }
        for(int i = 0;i < numberList.Count; i++)
        {
            Debug.Log(numberList[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
