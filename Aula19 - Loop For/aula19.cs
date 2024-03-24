using System;

class aula19{
    static void Main(){
        //Criando uma lista de números
            int[] numeros = {1,2,3,4,5};

            //Usando o for para percorrer a lista e exibir cada elemento
            for (int i = 0; i < numeros.Length; i++){
                Console.WriteLine("Elemento {0}: {1}",i,numeros[1]);
            }
    }
}