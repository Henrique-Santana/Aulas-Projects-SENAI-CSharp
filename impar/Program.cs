using System;

namespace impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            do{

            Console.WriteLine("Digite um Numero");
            numero = int.Parse(Console.ReadLine());
            
            if (numero !=0){
            if (numero % 2 == 0){
                Console.WriteLine("esse numero é par");
            }
            else {
                Console.WriteLine("esse numero é impar");
            }
            }             
            } while (numero != 0);
        }
    }
}
