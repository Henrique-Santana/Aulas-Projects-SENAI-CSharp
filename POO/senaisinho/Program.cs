using System;
using System.Collections.Generic;
using System.IO;

namespace senaisinho
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sala> sala1 =new List<Sala> ();
            string Local = ".\\ sala1.csv";

            sala1 = initList (@Local);

            int opcao = 0;

            System.Console.WriteLine("==senaisinho==");
            System.Console.WriteLine();
            System.Console.WriteLine("O que desejas?");
            System.Console.WriteLine("1 - Cadastrar Aluno");
            System.Console.WriteLine("2 - Cadastrar Sala");
            System.Console.WriteLine("3 - Alocar Aluno");
            System.Console.WriteLine("4 - Remover Aluno");
            System.Console.WriteLine("5 - Verificar Salas");
            System.Console.WriteLine("6 - Verificar Alunos");
            System.Console.WriteLine("0 – Sair");
            System.Console.Write("opção: ");
            opcao = int.Parse (Console.ReadLine());

            switch (opcao){
                case 3:
                
                    break;

            }
            
            
        //! fazer voltado para a sala,
        }
        static List<Sala> initList (string Local){
        List<Sala> sala1 = new List<Sala> ();

            try {
                string[] todoFile = File.ReadAllLines (@Local);

                foreach (string line in todoFile) {
                    string[] itens = line.Split (",");
                    string CapacidadeAtual = itens[0].Replace ("\"", "");
                    string CapacidadeTotal = itens[1].Replace ("\"", "");
                    string NumeroSala = itens[1].Replace ("\"", "");
                    string Alunos = itens[1].Replace ("\"", "");
                    Sala todoItem = new Sala (CapacidadeAtual, CapacidadeTotal,NumeroSala,Alunos);
                    sala1.Add (todoItem);
                }

                return sala1;

            } catch (IOException e) {
                Console.WriteLine ("Erro de Acesso.");
                Console.WriteLine (e.Message);
                return null;
            }
        }
    }
}
