using System;
using EscoladeRock.Interfaces;
namespace EscoladeRock.Models
{
    public class Guitarra : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de Guitarra");
            return true;
        }
    }
}