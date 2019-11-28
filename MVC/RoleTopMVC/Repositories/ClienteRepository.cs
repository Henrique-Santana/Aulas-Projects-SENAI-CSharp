using System.IO;

namespace RoleTopMVC.Repositories
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
    }
}