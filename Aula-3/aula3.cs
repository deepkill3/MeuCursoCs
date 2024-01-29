using Internal;
/*
                                        --+O que são variáveis?+--

    => São posições reservadas na memória RAM, pelo nosso programa, para armazenamento de dados.
exemplo: public float speed = 12f;

Neste exemplo, public significa a permissão de acesso da variável, sendo pública, pode ser alterada pelo 
programa. Float é o tipo de variável, nesse caso o tipo é float. Existem vários tipos de variáveis, tais como:

° int => Números inteiros (1, 2, 3, 4, etc...), com valores variados, ou seja, pode ser tanto positivo quanto 
negativo. Variáveis int possuem 32 bits.

° float => Números com pontos flutuantes (1.3, 1.5, 1.7, etc...)

° Byte => Valor inteiro sem sinal. O int em si, pode ser tanto positivo quanto negativo. O byte só tem um sinal
e tem apenas 8 bits (vai de 0 a 255).

° string => São tipos de vários caracteres em um só, mas sempre entre aspas (") ("Mateus", "Bryan", "123457",
etc...)

° Char => Determina um caracter apenas, mas sempre entre apóstrofos ('). ('a', 'b')

° bool => Determina se a variável é verdadeira ou falsa (True or False)

° var => Var não é necessariamente um tipo, ela determina que tal variável, pode ser do tipo do valor dela.
(var aux = "Mateus", quer dizer que a variável Mateus é do tipo string, mesmo sem eu precisar declarar o tipo
dela)

O speed, é o nome dado a essa variável. 12f é  valor dessa variável, sendo o mesmo, alocado na memória RAM da
máquina. (A letra "f", significa que esse valor em questão, é do tipo float)
*/

using System;

class Aula3 {
    static void Main() {
        float speed = 12f; //Variável tipo float
        int num = 0; //Variável tipo int
        char letter = 'm'; //Variável tipo char
        bool isWalking = false; //Variável tipo bool
        string name = "Mateus"; //Variável tipo string

        Console.WriteLine("Valor da variável speed é: "+speed);
        Console.WriteLine("Valor da variável num é: "+num);
        Console.WriteLine("Uma letra da variável letter: "+letter);
        Console.WriteLine("Eu estou andando? "+isWalking);
        Console.WriteLine("Valor da variável name é: "+name+"...");

        //Pode ser feito dessa forma:

        int num1, num2, res;
        num1 = 12;
        num2 = 22;
        res = num1 + num2;

        Console.WriteLine("O valor da expressão é "+res);
    }
}