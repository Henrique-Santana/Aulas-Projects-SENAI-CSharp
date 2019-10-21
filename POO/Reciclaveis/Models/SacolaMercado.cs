using Reciclaveis.Interfaces;
namespace Reciclaveis.Models
{
    public class SacolaMercado : Reciclar, IVermelho
    {
        public bool Vermelho(){
            System.Console.WriteLine("Joga-se na Lixeira Vermelha-Plastico");
            return true;
        }
    }
}