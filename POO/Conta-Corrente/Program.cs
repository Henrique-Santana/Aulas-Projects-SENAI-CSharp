using System;

namespace Conta_Corrente
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("==Consulta Conta Corrente==");
            System.Console.WriteLine();
            System.Console.Write("Agencia: ");
            int Agencia = int.Parse(Console.ReadLine());
            System.Console.Write("Numero: ");
            int Numero = int.Parse(Console.ReadLine());
            System.Console.Write("Titular: ");
            string Titular = Console.ReadLine();

            bool saldoValido = false;
            double saldo;
            do{
                System.Console.Write("digite o saldo: ");
                saldo = double.Parse(Console.ReadLine());
                if (saldo >= 0){
                    saldoValido = true;
                } else{
                    System.Console.WriteLine("O saldo não pode ser negativo");
                }
                
            } while (!saldoValido);
            ContaCorrente contaCorrente = new ContaCorrente(Agencia,Numero,Titular);
        }
    }
}
