using System;

class aula12 {
    static void Main()
    {
        Console.WriteLine("Digite um número:");
        string input = Console.ReadLine();

        // Convertendo o input para um número inteiro
        int numero;
        if (int.TryParse(input, out numero))
        {
            // Verificando se o número é positivo, negativo ou zero
            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }
}