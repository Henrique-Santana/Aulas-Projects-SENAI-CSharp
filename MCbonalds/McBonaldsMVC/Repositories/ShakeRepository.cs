using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class ShakeRepository
    {
        private const string PATH = "Database/Shake.csv"; //variavel indicando onde esta o .csv.
        public ShakeRepository() // Método de controle do arquivo csv
        {
            if(!File.Exists(PATH)) // confere se existe o arquivo Shake.csv, se não exixtir ele sera criado e se existir o codigo continuara.
            {
                File.Create(PATH).Close();
            }
            
        }

        public double ObterPrecoDe(string nomeShake)
        {
            var lista = ObterTodos();
            double preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nomeShake))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return(preco);
        }

        public List<Shake> ObterTodos()
        {
            List<Shake> shakes = new List<Shake>();

            var linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Shake s = new Shake();
                string[] dados =linha.Split(";");
                s.Nome = dados[0];
                s.Preco = double.Parse(dados[1]);
                shakes.Add(s);
            }
            return(shakes);

        }
    }
}