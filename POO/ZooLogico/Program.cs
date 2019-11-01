using System;
using System.Linq;
using ZooLogico.Models.Animais;
using ZooLogico.Interfaces;

namespace ZooLogico
{
    class Program
    {
        static void Main(string[] args)
        {
            var encerrouPrograma = false;
            do{
            var id = 0;
            System.Console.WriteLine("=====================");
            System.Console.WriteLine("    Zoo Lógico");
            System.Console.WriteLine("=====================");
            System.Console.WriteLine();
            System.Console.WriteLine("    Aninmais");
            foreach(var item in Todos.Animais.Values){
                System.Console.WriteLine($"{"",4}{++id}. {item.GetType().Name}");
            }

            try
                {
                    var opcaoUsuario = int.Parse(Console.ReadLine());
                    var animal = Todos.Animais[opcaoUsuario];
                    ClassificarAnimal(animal);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("Por favor, digite um código válido");
                    Console.ReadLine();
                    
                }
                } while (!encerrouPrograma);
        }
        public static ClassificarAnimal(Animal animal){

            var QClasse = animal.GetType();
            //QClasse esta querendo saber qual a classe do animal ex: animal arara -classe arara. Sempre que for referir ao nome do animal ,pode-se usar está variavel. 
            var @interface = classe.GetInterfaces().FirstOrDefault();
            //esta variavel esta querendo saber qual interface usada na classe do animal digitado, e depois fala que quer usar a primeira interface.
            


        }
    }
}
