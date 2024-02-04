/*
Em C#, operações bitwise são operações que manipulam os bits individuais de valores numéricos. As operações 
bitwise são frequentemente usadas para realizar operações específicas em nível de bit, como configurações de 
flags, compressão de dados, entre outras.

Aqui estão algumas das operações bitwise mais comuns em C#:

1- AND Bitwise (&):
Realiza uma operação AND bit a bit.
Exemplo:
int result = 5 & 3; // result = 1

2- OR Bitwise (|):

Realiza uma operação OR bit a bit.
Exemplo:
int result = 5 | 3; // result = 7

3- XOR Bitwise (^):

Realiza uma operação XOR bit a bit.
Exemplo:
int result = 5 ^ 3; // result = 6

4- Deslocamento para a Esquerda (<<):

Desloca os bits para a esquerda em um número específico de posições.
Exemplo:
int result = 5 << 2; // result = 20

5- Deslocamento para a Direita (>>):

Desloca os bits para a direita em um número específico de posições.
Exemplo:
int result = 8 >> 2; // result = 2

6- Complemento Bitwise (~):

Inverte todos os bits de um valor.
Exemplo:
int result = ~5; // result = -6

Essas operações são frequentemente usadas em situações em que você precisa manipular bits específicos dentro 
de valores numéricos. Por exemplo, ao trabalhar com configurações de flags em uma enumeração ou ao otimizar 
certas operações em nível de bit

*/

using System;

class aula9 {
    static void Main() {
        int num = 10;
        num = num<<1;

        Console.WriteLine(num);
    }
}