using System;
using Reciclaveis.Models;


namespace Reciclaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("Selecione o lixo que tu tenhas duvida");
            Console.WriteLine("=====================================");
            Console.WriteLine("");
            int codigo = int.Parse(Console.ReadLine());
            var Recicl = Lixos.lixos[codigo];

            /* Console.WriteLine("1 - Jornal.");
            Console.WriteLine("2 - Revista.");
            Console.WriteLine("3 - Sacolas de Mercado.");
            Console.WriteLine("4 - Caixinha de Leite.");
            Console.WriteLine("5 - Latinha.");
            Console.WriteLine("6 - Prego.");
            Console.WriteLine("7 - Espelho.");
            Console.WriteLine("8 - Maça Mordida.");     */
            
        }
    }
}
