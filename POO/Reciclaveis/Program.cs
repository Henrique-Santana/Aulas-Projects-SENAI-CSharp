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
            bool querSair = false;
            do
            {
                
            
            Console.WriteLine("1 - Jornal.");
            Console.WriteLine("2 - Revista.");
            Console.WriteLine("3 - Sacolas de Mercado.");
            Console.WriteLine("4 - Caixinha de Leite.");
            Console.WriteLine("5 - Latinha.");
            Console.WriteLine("6 - Maça Mordida .");
            Console.WriteLine("7 - Prego.");
            Console.WriteLine("8 - Espelho.");         
            Console.WriteLine("");
            Console.WriteLine("=====================================");
            Console.WriteLine("Selecione o lixo que tu tenhas duvida");
            Console.WriteLine("=====================================");
            int codigo = int.Parse(Console.ReadLine());
            if (codigo >=1 && codigo <=8){


            var Recicl = Lixos.lixos[codigo];

            Type tipoLixo = Recicl.GetType().GetInterfaces().FirstOrDefault();
            
            if(tipoLixo.Equals(typeof(IAmarelo)))
            {
                IAmarelo lixoConvertido = (IAmarelo)Recicl;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine($"{lixoConvertido.Amarelo()}");
                Console.ResetColor();

            }
            else if(tipoLixo.Equals(typeof(IAzul))){
                IAzul lixoConvertido = (IAzul)Recicl;
                Console.BackgroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"{lixoConvertido.Azul()}");
                Console.ResetColor();
            } 
            else if(tipoLixo.Equals(typeof(IOrganicos))){
                IOrganicos lixoConvertido = (IOrganicos)Recicl;
                Console.BackgroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{lixoConvertido.Organico()}");
                Console.ResetColor();
            }
            else if(tipoLixo.Equals(typeof(IVerde))){
                IVerde lixoConvertido = (IVerde)Recicl;
                Console.BackgroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{lixoConvertido.Verde()}");
                Console.ResetColor();
            }
            else if(tipoLixo.Equals(typeof(IVermelho))){
                IVermelho lixoConvertido = (IVermelho)Recicl;
                Console.BackgroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{lixoConvertido.Vermelho()}");
                Console.ResetColor();
            }
            else {
                Console.BackgroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine("nop");
                Console.ResetColor();
                
            }
            } else{
                Console.BackgroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine("mano tu digitou errado");
                Console.ResetColor();
            }
            System.Console.WriteLine("Aperte ENTER para voltar ao menu principal");
            Console.ReadLine();
            } while (!querSair);

            
        }
    }
}
