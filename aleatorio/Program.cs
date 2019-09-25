using System;

namespace aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
        int n, c, l, y;
            Console.WriteLine("Digite a quantida de triangulos: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Tamanho: ");
            n = int.Parse(Console.ReadLine());
                
        for(int q= 1; q<=y; q++){
            for(l=1;l<=n;l++) {
            for(c=1;c<=l;c++)
            Console.Write("*");
            Console.Write("\n");
        }
       }

        }   
    }
}
