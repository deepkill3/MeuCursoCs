using System.Reflection.Metadata;
/*
Diferente de uma variável, uma constante não pode ter seu valor alterado ao decorrer do programa.

usando a palavra reservada "const", para dizer que isso é uma constante, e seu valor inicial será sempre o
mesmo que foi setado.

                                        --+Exemplo+--

const
*/

using System;

class aula7 {
    static void Main() {
        const string nome = "Mateus";
        const double pi = 3.1415;

        Console.WriteLine("Meu nome é {0}\n Pi: {1}", nome, pi);

    }
}