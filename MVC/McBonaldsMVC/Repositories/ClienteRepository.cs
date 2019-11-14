using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class ClienteRepository
    {
        private const string PATH = "Database/Cliente.csv";//PATH é uma constante, onde fica o csv, para clialo.
        public ClienteRepository()
            {
                if(!File.Exists(PATH))//File Exists serve para conferir se existe o arquivo csv(PATH). 
                {
                    File.Create(PATH).Close();//Cria e Fecha.
                }
            }

            public bool Inserir(Cliente cliente)
            {
                var linha = new string[] {PrepararRegistroCSV(cliente)};
                File.AppendAllLines(PATH, linha);
                return true;
            }

            private string PrepararRegistroCSV(Cliente cliente)
            {
                return $"nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};endereco={cliente.Endereço};telefone{cliente.Telefone};data_nascimento={cliente.DataNascimento}";
            }
        
    }
}