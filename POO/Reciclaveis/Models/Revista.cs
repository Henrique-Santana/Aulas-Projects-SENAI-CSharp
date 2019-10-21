using Reciclaveis.Interfaces;
namespace Reciclaveis.Models
{
    public class Revista : Reciclar, IAzul
    {
        public bool Azul(){
            System.Console.WriteLine("Joga-se na Lixeira azul-papel");
            return true;
        }
    }
}