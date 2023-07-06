# Modulo 3

Linguagem: C#

Dedicado para aprender sobre os Scripts utilizando a linguagem C#
Visual Studio foi a ferramenta utilizada
Conceitos basicos de programacao
Todos os scripts foram disponibilizados nesta pasta
Homeword implementado ao final do modulo

## Topicos abordados

1. Classes
1. Variaveis e tipos de dados
1. Condicionais e operadores logicos
1. Loop de repeticao
1. Arrays, Matrizes e Listas
1. Metodos e Funcoes

Cada topico acima foi desenvolvido em arquivos exclusivos (separadamente)
Serao apresentados a seguir trechos de codigo que demonstram esse aprendizado

## Classes

> foram apresentados alguns conceitos sobre classes e orientacao a objetos
> Tambem foi apresentado alguns metodos reservados como:
```c#
    // Funcao executada quando o Objeto eh inicializado (antes mesmo da "Start")
    private void Awake();

    // Start is called before the first frame update
    void Start();

    // Update is called once per frame
    void Update();

    // Ligado a fisica da unity, ele so acontece quando houver fisica no meio
    void FixedUpdate();

    // Ocorre depois do Update, em todos os frames
    void LateUpdate();
    
```

## Variaveis e tipos de dados

>Conceito do uso de cabecalho e declaracao de variaveis
>No exemplo abaixo, as variaveis number1 e number2 estao disponiveis para o usuario alterar seus valores a qualquer momento
>Enquanto number3 pode ter seu valor alterado apenas no codigo
```c#
    [Header("Inteiros")]
    [SerializeField] int number1;
    [SerializeField] int number2 = 5;
    int number3;
```
![imagem](/Modulo3/imagens/header.png)

>A variavel de tipo GameObject foi um conceito novo apresentado nestas aulas
>Uma variavel que recebe um objeto
```c#
    // tipo especifico para objetos
    [SerializeField] GameObject objeto;
```

```c#
    Debug.Log(number1 + number2);

    Debug.Log("A soma é: " + number1 + number2);
    int soma = number1 + number2;
    Debug.Log("A soma é: " + soma);

    Debug.Log(word1 + word2);

    int squarenumber2 = number2 * number2;
    Debug.Log(number2 + word3 + squarenumber2);
```
![imagem](/Modulo3/imagens/Debug.png)
>Ferramenta "Debug.Log()" para visualizar valores na tela

## Condicionais e Operadores Logicos

>Uso de Ifs, else e operadores logicos (AND e OR)
```c#
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
```

## Loop de Repeticao

> Apresentados os loops "while" e "for"
```c#
    while(n < 100)
        {
            if(n %2 == 0)
            {
                Debug.Log(n);
            }
            // n = n + 1; possui o mesmo significado da linha abaixo
            n++;
        }
    for(int i = 0; i <= n; i++)
    {
        Debug.Log(i);
    }
```

## Arrays, Matrizes e Listas

> conceitos basicos sobre os famoso Arrays e em seguida apresentados conceitos de matris e listas
> Modo de *declaracao*, *atribuicao de valores* e *percorrimento*.
```c#
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
```
![imagem](/Modulo3/imagens/array.png)

## Metodos e Funcoes

> Nao obrigatororios mas extremamente importantes para facilitar o desenvolvimento e organizacao do codigo
```c#
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
```
![imagem](/Modulo3/imagens/funcao.png)

## Homework

> O exercicio pedia que, para um valor em dinheiro, fosse impresso a quantidade de notas e moedas correspondentes a aquele valor
> Desta forma, deve ser levado em conta a prioridade dos valores mais altos serem contados primeiro

> O valor em dinheiro e iniciado pelo programa mas pode ser mudado pelo usuario pela ferramenta
```c#
    [Header("Valor")]
    [SerializeField] float valorTotal = 235.5f;
```

> Foram implementadas funcoes auxiliares para pequenos calculos
```c#
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
```

> Funcoes para calculos da quantidade de notas e moedas
```c#
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
```

> Dentro da funcao "Start" foi feito o calculo de cada nota
> notas: 200, 100 , 50, 20, 10, 5, 2, 1.
> moedas: 50, 25, 10, 5, 1.

Exemplo de calculo de nota:
```c#
    float valor = valorTotal;

    // calcula qnt de notas de 200
    valor = Iteracao(valor, 200);
```

Exemplo de calculo de moeda:
```c#
    // parte decimal
    int cent = (int)(valor * 100);

    // calcula qnt de moedas de 50
    cent = Interacao_int(cent, 50);
```

## Resultados

![Parametros](/Modulo3/imagens/homework_parametros.png)

![Resultados](/Modulo3/imagens/homework_resultado.png)