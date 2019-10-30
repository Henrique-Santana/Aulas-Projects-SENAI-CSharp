using System;

namespace Exe20
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");

                int[] dados = new int[10];
                Random N = new Random();
                for(int i = 0; i < 10; i++){
                dados[i] = N;
                }

                foreach(int num in dados){
                System.Console.WriteLine($"{num}");

            }
        }
    }
}
