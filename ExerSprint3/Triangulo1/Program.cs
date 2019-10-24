using System;

namespace Triangulo1
{
    class Program
    {
        static void Main(string[] args)
        {
        double Lado1;
        double Lado2;
        double Base;
        double Altura;
        bool P = true;

            do{
            System.Console.WriteLine("# ============================================ #");
            System.Console.WriteLine("# Calcule a Área e Perímetro de seu Triangulo  #");
            System.Console.WriteLine("# ============================================ #");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o Altura do Triangulo");
            Altura = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o Primeiro Lado do Triangulo");
            Lado1 = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o Segundo Lado do Triangulo");
            Lado2 = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a Base do Tringulo");
            Base = Double.Parse(Console.ReadLine());
            
            double Area =((Altura * Base) /2);
            System.Console.WriteLine($"A Área do seu Triangulo é {Area}.");
            double Perímetro =(Lado1 + Lado2 + Base);
            System.Console.WriteLine($"O Perímetro do seu Triangolo è {Perímetro}.");

            System.Console.WriteLine("Aperter ENTER para calcular outro triangulo. ");
            Console.ReadLine();
            
            } while(!P);
        }
    }
}
