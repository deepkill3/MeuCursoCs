/*
                                    --+Lendo valores do teclado+--

Valores lido do teclado, significa assimilar o que o usuário digita ao seu programa.

Assim como exitem funções que escrevem no código (Write e WriteLine), existem funções que servem para ler o 
que foi escrito pelo o usuário e assim, armazenar esse valor a uma variável.

Exemplos:

=> Console.Read();
=> Console.ReadLine();

Ficaria assim:

string nome; (Variável declarada, mas sem valor)

nome = Console.ReadLine();

Dessa forma, será feita a requisição de algum valor para ser digitado pelo usuário e esse valor, será 
armazenado dentro da variável em questão (nesse caso a variável nome.)

*/

using Internal;
using System;

class aula8 {
    static void Main(){
        int v1, v2, soma;
        string nome;

        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Nome digitado foi {0}",  nome); // Mostra o que foi digitado.
        
        Console.WriteLine("\nAgora digite dois numeros:");
        v1 = Convert.ToInt32(Console.ReadLine()); // Lê um caractere e converte ele para Int32.
        v2 = Convert.ToInt32(Console.ReadLine()); // Da pra colocar o Read() ou o ReadKey(), pois o Read() é mais simples.
        soma  = v1 + v2;
        Console.WriteLine("A soma dos dois valores é {0}", soma);
    }
}