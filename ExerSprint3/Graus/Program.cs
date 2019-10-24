using System;

namespace Graus
{
    class Program
    {
        static void Main(string[] args)
        {
        int C;
        int F;
        string op;

            System.Console.WriteLine("Queres Converter: ");
            System.Console.WriteLine("1 - Celsius em Fahrenheit.");
            System.Console.WriteLine("2 - Fahrenheit em Celsius");
            op = (Console.ReadLine());

            switch (op)
            {
                case "1":
                System.Console.WriteLine("Digite a Temperatura em Celcius:");
                C = int.Parse(Console.ReadLine());                
                F=(9*C + 160)/5;
                System.Console.WriteLine($"A temperatura em Fahrenheit é {F} ");
                break;
                case "2":
                System.Console.WriteLine("Digite a Temperatura em Fahrenheit:");
                F = int.Parse(Console.ReadLine());
                C =(((9/ F)-160) *5);
                System.Console.WriteLine($"A temperatura em Celcius é {C} ");
                break;
            }
            
        }
    }
}
