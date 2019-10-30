using System;
using System.Collections;
using System.Collections.Generic;

namespace Exe20
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] listaAleatorio = new int[10];
            Random randomNumero = new Random();
            List<int> numPar = new List<int>();
            List<int> numImpar = new List<int>();


            for (int i = 0; i < 10; i++)
            {
                listaAleatorio[i] = randomNumero.Next(1, 10);
                if (listaAleatorio[i] % 2 == 0)
                {
                    numPar.Add(listaAleatorio[i]);
                }
                else
                {
                    numImpar.Add(listaAleatorio[i]);
                }
            }


            System.Console.WriteLine("lista: ");
            foreach (var num in listaAleatorio)
            {
                System.Console.Write($"{num} ; ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("lista impar: ");
            foreach (var num in numImpar)
            {
                System.Console.Write($"{num} ;");
            }
            System.Console.WriteLine();

            System.Console.WriteLine("lista par: ");
            foreach (var num in numPar)
            {
                System.Console.Write($"{num} ;");
            }


        }
    }
}
