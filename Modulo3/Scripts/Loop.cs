using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    int n;

    // Start is called before the first frame update
    void Start()
    {
        while(n < 100)
        {
            if(n %2 == 0)
            {
                Debug.Log(n);
            }
            // n = n + 1;
            n++;
        }

        for(int i = 0; i <= n; i++)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
