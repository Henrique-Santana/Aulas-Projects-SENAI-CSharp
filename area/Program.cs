using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            string forma;
            int lado1;
            int lado2;
            int base1;
            int altura1;
            int raio1;

            do{
            Console.WriteLine("escolha qual forma geométrica para calcular o lado:");
            Console.WriteLine("quadrado");
            Console.WriteLine("triangulo");
            Console.WriteLine("circulo");
            Console.WriteLine("retangulo");
            forma = Console.ReadLine();

            switch (forma){
                case "quadrado":
                Console.WriteLine("digite um lado");
                lado1 = int.Parse(Console.ReadLine());
                Console.WriteLine("digite outro lado");
                lado2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{lado1} * {lado2} = {lado1 + lado2}");
                break;

                case "triangulo":
                Console.WriteLine("digite a base");
                base1 = int.Parse(Console.ReadLine());
                Console.WriteLine("digite um altura");
                altura1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{base1} * {altura1} / {2}= {base1 * altura1 / 2}");
                break;

                case "circulo":
                Console.WriteLine("digite o raio");
                raio1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{3.14} * {raio1} * {raio1}= {raio1 * raio1 * raio1}");
                break;

                case "retangulo":
                Console.WriteLine("digite a base");
                base1 = int.Parse(Console.ReadLine());
                Console.WriteLine("digite um altura");
                altura1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{base1} * {altura1}= {base1 * altura1}");
                break;

            }
            }
            while(forma != "fim");
        }
    }
}
