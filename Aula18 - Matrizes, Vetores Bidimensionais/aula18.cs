using System;

class Program
{
    static void Main()
    {
        // Exemplo de matriz de inteiros 3x3
        int[,] matrizInteiros = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Exibe os valores da matriz de inteiros
        Console.WriteLine("Valores da matriz de inteiros:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrizInteiros[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
