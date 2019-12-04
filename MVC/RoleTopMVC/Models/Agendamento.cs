namespace RoleTopMVC.Models
{
    public class Agendamento
    {
        public ulong Id {get; set;} // atributo para identificar o pedido
        public Cliente Cliente {get; set;}
        public double PrecoTotal {get;set;}
        public uint Status {get; set;} // atributo para saber se o pedido esta aprovado, reprovado ou pendente

        // conferrir = criar classe opcionais com os opcionais, opcionais1 e opcionais2 onde opcionais1={pedido.opcional1};opcionais2={pedido.opcional2}.

    }
}