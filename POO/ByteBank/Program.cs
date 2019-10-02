using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Cadastro de Cliente");
            System.Console.WriteLine();
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.WriteLine("Cpf: ");
            string cpf = Console.ReadLine();
            System.Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            Cliente cliente1 = new Cliente(nome,cpf,email);

            bool trocousenha = false;
            do{
                System.Console.WriteLine("Digite a Senha: ");
                string senha = Console.ReadLine();
                trocousenha = cliente1.TrocaSenha(senha);
                if (!trocousenha){
                    System.Console.WriteLine("Senha não atende aos Requisitos");
                } else {
                    System.Console.WriteLine("Senha trocada com sucesso");
                }
            } while(!trocousenha);
        }
    }
}
