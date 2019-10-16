using System;
using EscoladeRock.Interfaces;

namespace EscoladeRock.Models
{
    public class Baixo : InstrumentoMusical,IPercurssao, IMelodia, IHarmonia
    {
    public bool ManterRitmo()
    {
        System.Console.WriteLine("Manter ritmo do Baixo");
        return true;
    }    
    public bool TocarAcordes()
    {
        System.Console.WriteLine("Tocando acordes de Baixo");
        return  true;
    }
    }
}