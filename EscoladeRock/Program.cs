using System;
using EscoladeRock.Models;

namespace EscoladeRock
{
    enum FormacaoEnum : int
    {
        TRIO = 3,
        QUARTETO
    };
    enum InstrumentosEnum :  int {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLAO
    };
    enum CategoriaEnum : int {
        HARMONIA,
        PERCUSSAO,
        MELODIA
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));/*typeof pega o nome inves dos valores */
            string[] itensMenuCategorias = Enum.GetNames(typeof(CategoriaEnum)); 

            var opcoesFormacao = new List <string>()
            {
                "   -0    ",
                "   -1    "
            };

            int opcaoFormacao = 0;
            string menuBar = "============";

            do{
                bool formacaoEscolhida = false;
                do{
                    
                }
            }

        }
    }
}
