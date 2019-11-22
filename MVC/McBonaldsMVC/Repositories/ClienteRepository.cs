using System;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class ClienteRepository
    {
        private const string PATH = "Database/Cliente.csv";//PATH é uma constante, onde fica o csv, para crialo.
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

            public Cliente ObterPor(string email)
            {
                var linhas = File.ReadAllLines(PATH);
                foreach (var linha in linhas)
                {
                    if(ExtrairValorDoCampo("email", linha).Equals(email))
                    {
                        Cliente c = new Cliente();
                        c.Nome = ExtrairValorDoCampo("nome", linha);
                        c.Email = ExtrairValorDoCampo("email", linha);
                        c.Senha = ExtrairValorDoCampo("senha", linha);
                        c.Endereço = ExtrairValorDoCampo("endereço", linha);
                        c.Telefone = ExtrairValorDoCampo("telefone", linha);
                        c.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("dataNascimento", linha));

                        return c;
                    }
                }
                return null;
            }

            private string PrepararRegistroCSV(Cliente cliente)
            {
                return $"nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};endereço={cliente.Endereço};telefone{cliente.Telefone};dataNascimento={cliente.DataNascimento}";
            }

            public string ExtrairValorDoCampo(string nomeCampo, string linha)
            {
                var chave = nomeCampo;
                var indiceChave = linha.IndexOf(chave);

                var indiceTerminal = linha.IndexOf(";", indiceChave);
                var valor = "";

                if(indiceTerminal != -1)
                {
                    valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
                }
                else
                {
                    valor = linha.Substring(indiceChave);
                }
                System.Console.WriteLine($"Camppo{nomeCampo} tem valor {valor}");
                return valor.Replace(nomeCampo + "=", "");

            }
        
    }
}