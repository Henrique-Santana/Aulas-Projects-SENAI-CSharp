using Reciclaveis.Interfaces;
namespace Reciclaveis.Models
{
    public class Latinha : Reciclar, IAmarelo
    {
        public bool Amarelo(){
            System.Console.WriteLine("Joga-se na Lixeira Amarela - Metal");
            return true;
        }
    }
}