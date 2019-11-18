using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class HamburguerRepository
    {
        private const string PATH = "Database/Hamburgueres.csv";
        public HamburguerRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        public double ObterPrecoDe(string nomeHamburguer)
        {
            var lista = ObterTodos();
            double preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nomeHamburguer))
                {
                    preco = item.Preco;
                    break;
                }
            }
            return(preco);
        }

        public List<Hamburguer> ObterTodos()
        {
            List<Hamburguer> hamburgueres = new List<Hamburguer>();// cria uma lista.

            string[] linhas = File.ReadAllLines(PATH);//cria um arrey onde ele usa o readALLlines para ler Linha por linha do PATH e armazena na string[] linhas.
            foreach (var linha in linhas)//Agora o foreach armazena os dados de linhas e armazena linha e depois executa oq esta dentro do metodo.  
            {
                Hamburguer h = new Hamburguer(); //cria uma variavel h de Hamburguer  
                string[] dados = linha.Split(";"); //dados serve para pegar a variavel linha e usar o split para "organizar as informações quando chega no ';' "
                h.Nome = dados[0];
                h.Preco = double.Parse(dados[1]);
                hamburgueres.Add(h); // add a varivel h que é uma linha da lista de hamburgueres em hamburgures para dps retornar a lista hamburgueres.
            }
            return hamburgueres;//returna a lista com os valores 
        } 
    }
}