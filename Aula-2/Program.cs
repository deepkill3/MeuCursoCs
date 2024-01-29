using System;

namespace Aula2 
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Eu amo a Evelyn");
            if(args.GetLength(0)>0){
            Console.WriteLine(args.GetValue(0));
            }
        }
    }
}