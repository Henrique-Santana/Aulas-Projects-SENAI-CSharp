using System;
using Reciclaveis.Models;
using Reciclaveis.Interfaces;
using System.Linq;



namespace Reciclaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Jornal.");
            Console.WriteLine("2 - Revista.");
            Console.WriteLine("3 - Sacolas de Mercado.");
            Console.WriteLine("4 - Caixinha de Leite.");
            Console.WriteLine("5 - Latinha.");
            Console.WriteLine("6 - Prego.");
            Console.WriteLine("7 - Espelho.");
            Console.WriteLine("8 - Maça Mordida.");         
            Console.WriteLine("");
            Console.WriteLine("=====================================");
            Console.WriteLine("Selecione o lixo que tu tenhas duvida");
            Console.WriteLine("=====================================");
            int codigo = int.Parse(Console.ReadLine());
            var Recicl = Lixos.lixos[codigo];

            Type tipoLixo = Recicl.GetType().GetInterfaces().FirstOrDefault();
            
            if(tipoLixo.Equals(typeof(IAmarelo)))
            {
                IAmarelo lixoConvertido = (IAmarelo)Recicl;
                System.Console.WriteLine($"{lixoConvertido.Amarelo()}");

            } else {
                System.Console.WriteLine("nop");
            }
            
        }
        /*public static bool Mostrar() {
            
        }  */
    }
}
