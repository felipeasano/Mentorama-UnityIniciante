using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Funcao executada quando o Objeto eh inicializado (antes mesmo da "Start")
    private void Awake()
    {
        // funcao/comando que auxilia a debugar o cod,
        // desta forma imprime na tela a mensagem inserida no momento em que foi executado
        Debug.Log("Mentorama");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Ligado a fisica da unity, ele so acontece quando houver fisica no meio
    void FixedUpdate()
    {
        
    }

    // Ocorre depois do Update, em todos os frames
    void LateUpdate()
    {
        
    }
}
