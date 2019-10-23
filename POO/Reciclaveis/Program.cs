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
            Console.WriteLine("6 - Prego.");
            Console.WriteLine("7 - Espelho.");
            Console.WriteLine("8 - Maça Mordida.");         
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
                System.Console.WriteLine($"{lixoConvertido.Amarelo()}");

            }
            else if(tipoLixo.Equals(typeof(IAzul))){
                IAzul lixoConvertido = (IAzul)Recicl;
                System.Console.WriteLine($"{lixoConvertido.Azul()}");
            } 
            else if(tipoLixo.Equals(typeof(IOrganicos))){
                IOrganicos lixoConvertido = (IOrganicos)Recicl;
                System.Console.WriteLine($"{lixoConvertido.Organico()}");
            }
            else if(tipoLixo.Equals(typeof(IVerde))){
                IVerde lixoConvertido = (IVerde)Recicl;
                System.Console.WriteLine($"{lixoConvertido.Verde()}");
            }
            else if(tipoLixo.Equals(typeof(IVermelho))){
                IVermelho lixoConvertido = (IVermelho)Recicl;
                System.Console.WriteLine($"{lixoConvertido.Vermelho()}");
            }
            else {
                System.Console.WriteLine("nop");
            }
            } else{
                System.Console.WriteLine("mano tu digitou errado");
            }
            System.Console.WriteLine("Aperte ENTER para voltar ao menu principal");
            Console.ReadLine();
            } while (!querSair);

            
        }
    }
}
