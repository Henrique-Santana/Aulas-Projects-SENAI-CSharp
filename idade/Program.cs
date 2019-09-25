using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int nascim = 0;
            int anoatual = 2019;
            int idade;

            Console.WriteLine("digite seu ano de nascimento");
            nascim = int.Parse(Console.ReadLine());


            idade = (anoatual - nascim);

            if(idade <= 2){
                Console.WriteLine("Recém-Nascido");
            } else if ((idade >=3) && (idade <=11)){
                Console.WriteLine("Criança");
            } else if ((idade >= 12) && (idade <=19)){
                Console.WriteLine("Adolecente");
            } else if ((idade >=20) && (idade <=65)){
                Console.WriteLine("adulto");
            } else if (idade >65){
                Console.WriteLine("idoso");
            }
            }

        }
    }
