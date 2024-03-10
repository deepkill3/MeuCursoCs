using System;

class Program
{
    static void Main()
    {
        // Exemplo de declaração e inicialização de um array de inteiros
        int[] numeros = new int[5]; // Cria um array de inteiros com tamanho 5

        // Atribui valores ao array
        numeros[0] = 10;
        numeros[1] = 20;
        numeros[2] = 30;
        numeros[3] = 40;
        numeros[4] = 50;

        // Exibe os valores do array
        Console.WriteLine("Valores do array de inteiros:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Elemento {i}: {numeros[i]}");
        }

        // Exemplo de declaração e inicialização de um array de strings
        string[] nomes = { "Alice", "Bob", "Charlie", "David", "Eva" };

        // Exibe os valores do array de strings
        Console.WriteLine("\nValores do array de strings:");
        foreach (string nome in nomes)
        {
            Console.WriteLine("Nome: {nome}");
        }
    }
}