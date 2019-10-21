using System.Collections.Generic;


namespace Reciclaveis.Models
{
    public class Lixos
    {
        public static Dictionary<int,Reciclar > lixos = new Dictionary<int, Reciclar>() {
            { 1, new Jornal() },
            { 2, new Revista() },
            { 3, new SacolaMercado() },
            { 4, new CaixinhaLeite() },
            { 5, new Latinha() },
            { 6, new MaçaMordida() },
            { 7, new Prego() },
            { 8, new Espelho() }

        };
    }
}