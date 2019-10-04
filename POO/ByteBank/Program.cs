using System;

namespace ByteBank {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Cadastro de Cliente");
            System.Console.WriteLine ();
            System.Console.Write ("Nome: ");
            string nome = Console.ReadLine ();
            System.Console.Write ("Cpf: ");
            string cpf = Console.ReadLine ();
            System.Console.Write ("Email: ");
            string email = Console.ReadLine ();

            Cliente cliente1 = new Cliente (nome, cpf, email);

            bool trocousenha = false;
            do {
                System.Console.WriteLine ("Digite a Senha: ");
                string senha = Console.ReadLine ();
                trocousenha = cliente1.TrocaSenha (senha);
                if (!trocousenha) {
                    System.Console.WriteLine ("Senha não atende aos Requisitos");
                } else {
                    System.Console.WriteLine ("Senha trocada com sucesso");
                }
            } while (!trocousenha);

            Console.Clear ();
            System.Console.WriteLine ("cadastro de conta corrente");
            System.Console.WriteLine ();
            System.Console.Write ("Agencia: ");
            int Agencia = int.Parse (Console.ReadLine ());
            System.Console.Write ("Numero: ");
            int Numero = int.Parse (Console.ReadLine ());
            /*  System.Console.Write("Titular: ");
            int Titular = int.Parse(Console.ReadLine());*/

            bool saldoValido = false;
            double saldo;
            do {
                System.Console.Write ("Digite o saldo: ");
                saldo = double.Parse (Console.ReadLine ());
                if (saldo >= 0) {
                    saldoValido = true;
                } else {
                    System.Console.WriteLine ("o saldo não pode ser negativo");
                }
            } while (!saldoValido);

            ContaCorrente contaCorrente = new ContaCorrente (Agencia, Numero, cliente1);
            contaCorrente.Saldo = saldo;

            System.Console.WriteLine ("ByteBank - Depósito");
            Cliente usuario = contaCorrente.Titular;
            System.Console.WriteLine ($"Bem vindo - {usuario.Nome}");
            System.Console.Write ("Digite o valor do depósito");
            double valor = double.Parse (Console.ReadLine ());
            contaCorrente.Deposito (valor);
            System.Console.WriteLine ();
            System.Console.WriteLine ("ByteBank - Saque");
            System.Console.Write ("Qual o valor do saque?");
            valor = double.Parse (Console.ReadLine ());
            if (contaCorrente.Saque (valor)) {
                System.Console.WriteLine ("Saque realizado com sucesso. Retire as notas");
            } else {
                System.Console.WriteLine ("Não foi possivel realizar a operações");
            }
            System.Console.WriteLine ();

            System.Console.WriteLine ("ByteBank - Transferencia");
            System.Console.WriteLine ("Digite o valor da transferência");
            valor = double.Parse (Console.ReadLine ());
            if (contaCorrente.Saque (valor)) {
                System.Console.WriteLine ("Saque realizado com sucesso.Retire as notas");
            } else {
                System.Console.WriteLine ("Não foi possivel realizar a operação");
            }

            /* 
            System.Console.Write("Depósito: ");
            int Depósito = int.Parse(Console.ReadLine());
            System.Console.Write("Saque: ");
            int Saque = int.Parse(Console.ReadLine());
            System.Console.Write("Transferência: ");
            int Transferência = int.Parse(Console.ReadLine());
            */
        }
    }
}