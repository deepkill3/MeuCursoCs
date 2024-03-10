using System;

class Program
{
    static void Main()
    {
        // Exemplo de matriz de strings 2x2
        string[,] matrizStrings = {
            {"A", "B"},
            {"C", "D"}
        };

        // Exibe os valores da matriz de strings
        Console.WriteLine("Valores da matriz de strings:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matrizStrings[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
