/*
                                            Comando GoTo

O comando goto em C# é uma instrução de controle de fluxo que permite transferir o controle do programa para 
uma outra parte do código identificada por um rótulo (label). No entanto, o uso do goto é desencorajado na 
maioria dos casos, pois pode tornar o código difícil de entender e dar origem a problemas de manutenção.

A sintaxe básica do goto em C# é a seguinte:
    goto label;

// ...

label:
// Código a ser executado quando o goto é alcançado

                                    Aqui está um exemplo simples do uso do goto:
using System;

class Program
{
    static void Main()
    {
        int i = 1;
    loop:
        Console.WriteLine(i);
        i++;
        if (i <= 5)
            goto loop;
    }
}

Neste exemplo, o programa entra em um loop simples, exibindo os números de 1 a 5, e utiliza o goto para 
voltar ao rótulo loop até que i seja maior que 5.

É importante notar que o uso excessivo de goto pode levar a um código desorganizado e difícil de entender. Em 
muitos casos, é preferível usar estruturas de controle de fluxo mais estruturadas, como for, while, do-while, 
if-else, entre outras, para manter o código mais legível e fácil de dar manutenção.
*/

using System;
class aula16 {
    static void Main(){
        int tempo=0;
        char escolha;

    //Label
        inicio:

        Console.Clear(); //Limpa o console quando chegar nesse ponto.

        Console.WriteLine("De Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o transporte:[a]Avião | [c]Carro | [o]Ônibus");
        escolha = char.Parse(Console.ReadLine());
        switch(escolha){
            case 'a':
            case 'A':
                tempo = 50;
                break;
            case 'c':
            case 'C':
                tempo = 480;
                break;
            case 'o':
            case 'O':
                tempo = 660;
                break;
            default:
                tempo=-1;
                break;
        }
        if(tempo <0){
            Console.WriteLine("Transporte indisponível");
        }
        else {
            Console.WriteLine("Para o transporte escolhido, o tempo é: {0} minutos", tempo);
        }

        Console.WriteLine("Calcular outro transporte?[s/n]");
        escolha=char.Parse(Console.ReadLine());

        if(escolha == 's' || escolha == 'S'){
            goto inicio;
        }
        else{
            Console.Clear();
            Console.WriteLine("Fim do programa.");
        }
    }
}