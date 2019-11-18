using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class PedidoRepository
    {
        private const string PATH = "Database/Pedido.csv";//PATH é uma constante, onde fica o csv, para clialo.

        public PedidoRepository ()
            {
                if(!File.Exists(PATH))//File Exists serve para conferir se existe o alquivo csv(PATH) , 
                {
                    File.Create(PATH).Close();//Cria o csv e fecha.
                }
            }

            public bool Inserir(Pedido pedido)
            {
                var linha = new string[] {PrepararRegistroCSV(pedido)};
                File.AppendAllLines(PATH, linha);
                return true;
            }

            private string PrepararRegistroCSV(Pedido pedido)
            {
                Cliente cliente = pedido.Cliente;
                Hamburguer hamburguer = pedido.Hamburguer;
                Shake shake = pedido.Shake;

                return $"cliente_nome={cliente.Nome};cliente_endereço={cliente.Endereço};cliente_telefone={cliente.Telefone};cliente_email={cliente.Email};hamburguer_nome={hamburguer.Nome};hamburguer_preco={hamburguer.Preco};shake_nome={shake.Nome};shake_preco={shake.Preco};data_pedido={pedido.DatadoPedido};preco_total={pedido.PrecoTotal}";
            }
    }
}