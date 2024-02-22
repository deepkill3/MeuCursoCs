/*
if aninhado (if dentro de if)
*/

using System;
class aula14{
   static void Main()
    {
        Console.WriteLine("Digite sua idade:");
        string input = Console.ReadLine();

        // Convertendo o input para um número inteiro
        int idade;
        if (int.TryParse(input, out idade))
        {
            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");

                if (idade >= 65)
                {
                    Console.WriteLine("Você é um idoso.");
                }
            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }
}