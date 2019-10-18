using System;
namespace ByteBank2.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(int Agencia, int NumeroConta, string Titular): base(Agencia,NumeroConta,Titular) 
        {/*o base(Agencia,NumeroConta,Titular) é para chamar os dados que quer ser herdado da class pai*/ /*o ":" serve para falar de qual class quer ser herdado no caso a class pai*/
            
        }
        
        public  override bool Saque(double valor)
        {
            if (valor <= 0)
            {
                if (valor<= this.Saldo)
                {
                    this.Saldo -= valor;
                    return true;
                } else{
                    return false;
                }
            return false;
            }
        }
    }
}