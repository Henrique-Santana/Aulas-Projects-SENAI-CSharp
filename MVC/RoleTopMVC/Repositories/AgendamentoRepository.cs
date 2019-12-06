using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class AgendamentoRepository : RepositoryBase
    {
    private const string PATH = "Database/Pedido.csv";//PATH é uma constante, onde fica o csv, para crialo.
    public PedidoRepository ()
        {
            if(!File.Exists(PATH))//File Exists serve para conferir se existe o alquivo csv(PATH) , 
            {
                File.Create(PATH).Close();//Cria o csv e fecha.
            }
        }

    public bool Inserir(Agendamento agendamento)
        {
            var quantidadeLinhas = File.ReadAllLines(PATH).Length;
            pedido.Id = (ulong) ++quantidadeLinhas;
            var linha = new string[] {PrepararRegistroCSV(pedido)};
            File.AppendAllLines(PATH, linha);
            return true;
        }
    }
}