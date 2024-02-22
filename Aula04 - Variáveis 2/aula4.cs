using Internal;
using System;

/*
    Variáveis criadas dentro de um certo método, não podem ser chamadas dentro de outro método, pois por padrão,
    a variável é criada como privada, ou seja, só pode ser acessada pelo seu própio método.

    Para uma variável ser acessada por outros métodos, geralmente ela é criada dentro do escopo da classe.
*/


class aula4 {
        int num = 0;
    static void Main(){
        int num2 =12;
        Console.WriteLine(num2);
    }

    void test() {
        Console.WriteLine(num);
    }
}