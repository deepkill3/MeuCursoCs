using System;

class aula19{
    static void Main(){
        //Criando uma lista de números
        int[]num = new int[10];


        //Usando o for para percorrer a lista e exibir cada elemento
        for(int i = 0; i < num.Length; i++) {
            num[i] = i;
        }
        for(int i = 0; i < num.Length; i++) {
            Console.WriteLine("Valor de Num na pos{0}: {1}", i, num[i]);
        }
    }
}