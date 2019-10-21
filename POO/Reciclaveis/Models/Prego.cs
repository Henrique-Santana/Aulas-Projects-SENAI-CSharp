using Reciclaveis.Interfaces;
namespace Reciclaveis.Models
{
    public class Prego : Reciclar, IAmarelo
    {
        public bool Amarelo(){
            System.Console.WriteLine("Joga-se na Lixeira Amarela - Metal");
            return true;
        }
    }
}