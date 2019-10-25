using System;

namespace Troca
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("escreva numero A");
            int A = int.Parse(Console.ReadLine());
            System.Console.WriteLine("escreva numero B");
            int B = int.Parse(Console.ReadLine());

            int C = B;
            B = A;
            A = C;

            System.Console.WriteLine($"Valor de A: {A}");
            System.Console.WriteLine($"Valor de B: {B}");
            
        }
    }
}
