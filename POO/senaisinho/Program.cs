using System;

namespace senaisinho
{
    class Program
    {
        static void Main(string[] args)
        {


            System.Console.WriteLine("==senaisinho==");
            System.Console.WriteLine();
            System.Console.WriteLine("cadastrar aluno");
            System.Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            System.Console.Write("Data de Nascimento: ");
            DateTime DataNascimento = DateTime.Parse(Console.ReadLine());
            System.Console.Write("Curso: ");
            string Curso = Console.ReadLine();
            System.Console.Write("Numero da Sala: ");
            int NumeroSala = int.Parse(Console.ReadLine());
            
            Aluno aluno = new Aluno(Nome, DataNascimento,Curso, NumeroSala); 
            
        
        }
    }
}
