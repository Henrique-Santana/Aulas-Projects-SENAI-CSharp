using System;

namespace Exe19
{
    class Program
    {
        static void Main(string[] args)
        {
         //indice 01234
        //valores 12345
        
            Console.WriteLine("Quantas Posições? ");
            int N = int.Parse(Console.ReadLine());

            int[] dados = new int[N];
                
            for(int cont = 0; cont<N; cont++){ 
            Console.Write("digite um número: ");
            dados[cont] = int.Parse(Console.ReadLine());
            }
            dados[1] = dados[3];

            foreach(int num in dados){
                System.Console.WriteLine($"{num}");

            }
        }
    }
}
