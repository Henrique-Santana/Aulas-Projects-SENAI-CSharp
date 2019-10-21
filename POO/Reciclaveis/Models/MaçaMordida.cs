using Reciclaveis.Interfaces;
namespace Reciclaveis.Models
{
    public class MaçaMordida : Reciclar ,IOrganicos
    {
        public bool Organico(){
            System.Console.WriteLine("Joga-se na Lixeira Marrom - Organico");
            return true;
        }
    }
}