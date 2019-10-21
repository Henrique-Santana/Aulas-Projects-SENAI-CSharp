using Reciclaveis.Interfaces;
namespace Reciclaveis.Models
{
    public class Espelho : Reciclar, IVerde
    {
        public bool Verde(){
            System.Console.WriteLine("Joga-se na Lixeira Verde - vidro");
            return true;
        }
    }
}