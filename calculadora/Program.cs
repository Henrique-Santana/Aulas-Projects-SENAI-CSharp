using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string oper;

            Console.WriteLine("digite o 1º numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o 2º numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("qual o operador desejado");
            Console.WriteLine("somar = +");
            Console.WriteLine("subtrair = -");
            Console.WriteLine("multiplicar = *");
            Console.WriteLine("dividir = /");
            Console.WriteLine("porcentagem = %");
            oper = Console.ReadLine();

            switch (oper){
                case"+":
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
                case"-":
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
                case"*":
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
                case "/":
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break;
                case "%":
                Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                break;
            }
        }
    }
}
