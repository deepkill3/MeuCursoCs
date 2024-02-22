using Internal;
using System;

/*
        Comandos de escape:

\n => Executa uma quebra de linha (tecla enter)
\t => Tecla de tabulação (Comando da tecla tab)
:c => Formatação em valor monetário (R$, USS, Eur, etc...)
:p => Formatação em porcetagem


Exemplos em "extra.cs"

!! Pode ser feita uma sequencia, usando vários desses comandos um atrás do outro.
*/

class aula6 {
    static void Main() {
        int n1, n2, n3;

        n1 = 1;
        n2 = 2;
        n3 = 3;

        Console.WriteLine("n1=\t{0}\n n2=\t{1}\n n3=\t{2}\n", n1, n2, n3);
    }
}