/*
Operadores e Operações


Em C#, operadores são símbolos que realizam operações em variáveis e valores. Eles são usados para realizar 
cálculos, comparações e outras operações em dados.

+ (adição)
- (subtração)
* (multiplicação)
/ (divisão)
% (módulo, retorna o resto da divisão)

int a = 5;
int b = 3;

int soma = a + b;    // 8
int subtracao = a - b; // 2
int multiplicacao = a * b; // 15
int divisao = a / b; // 1
int modulo = a % b; // 2

==============================================================================================================

Operadores de Atribuição:
= (atribuição)
+=, -=, *=, /= (operadores de atribuição combinados)

int x = 10;
x += 5; // x agora é 15

==============================================================================================================

Operadores de Comparação:
== (igual)
!= (diferente)
< (menor que)
> (maior que)
<= (menor ou igual a)
>= (maior ou igual a)

int a = 5;
int b = 10;

bool igual = (a == b);    // false
bool diferente = (a != b); // true
bool menorQue = (a < b);   // true
bool maiorQue = (a > b);   // false

==============================================================================================================

Operadores Lógicos:
&& (E lógico)
|| (OU lógico)
! (NÃO lógico)

bool condicao1 = true;
bool condicao2 = false;

bool resultadoAnd = condicao1 && condicao2; // false
bool resultadoOr = condicao1 || condicao2;  // true
bool resultadoNot = !condicao1;             // false

==============================================================================================================

Operadores de bitwise (Manipulação de bits)
& (E bit a bit)
| (OU bit a bit)
^ (OU exclusivo bit a bit)
~ (Negação bit a bit)
<< (Shift left)
>> (Shift right)

int a = 5;   // Representação binária: 00000101
int b = 3;   // Representação binária: 00000011

int resultadoAnd = a & b;   // 00000001 (1 em binário)
int resultadoOr = a | b;    // 00000111 (7 em binário)
int resultadoXor = a ^ b;   // 00000110 (6 em binário)
int resultadoNot = ~a;      // 11111010 (representação negada de 5 em binário)
int resultadoShiftLeft = a << 1;  // 00001010 (10 em binário)
int resultadoShiftRight = a >> 1; // 00000010 (2 em binário)


Estes são apenas alguns dos operadores disponíveis em C#. Eles são fundamentais para realizar várias operações 
em programação.
*/

using System;

class aula5 {
    static void Main() {

    }
}