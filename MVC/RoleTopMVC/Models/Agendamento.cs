namespace RoleTopMVC.Models
{
    public class Agendamento
    {
        
        public string Opcional1 {get; set;}
        public string Opcional2 {get; set;}
        public string Endereco {get; set;}
        public string TipoPagamento {get; set;}
        public string TipoEvento {get; set;}
        public ulong Id {get; set;} // atributo para identificar o Agendamento.
        public Cliente cliente {get; set;}
        public double PrecoTotal {get;set;}
        public uint Status {get; set;} // atributo para saber se o agendamento esta aprovado, reprovado ou pendente.


        public Agendamento()
        {
            this.Id = 0;
            this.cliente = new Cliente();
            this.Status = Status;
            this.Opcional1 = Opcional1;
            this.Opcional2 = Opcional2;
            this.Endereco = Endereco;
            this.TipoPagamento = TipoPagamento;
            this.TipoEvento = TipoEvento;
        }



        // conferrir = criar classe opcionais com os opcionais, opcionais1 e opcionais2 onde opcionais1={Agendamento.opcional1};opcionais2={Agendamento.opcional2}.

    }
}