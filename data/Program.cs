using System;

namespace data
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;

            Console.WriteLine("digite a sua idade");
            idade = int.Parse(Console.ReadLine());


            Console.WriteLine("sua idade em dias é " + idade * 365);
            Console.WriteLine("sua idade em meses é " + idade * 8760);
            Console.WriteLine("sua idade em horas é " + idade * 525600);
            Console.WriteLine("sua idade em semanas é " + idade * 216);
        }
    }
}
