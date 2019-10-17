namespace senaisinho
{
    public class Sala
    {
        public int CapacidadeAtual ;
        public int CapacidadeTotal = 10;
        public int NumeroSala;
        public string Alunos;

        public Sala (int CapacidadeAtual,int CapacidadeTotal, int NumeroSala,string Alunos){
            this.CapacidadeAtual = CapacidadeAtual;
            this.CapacidadeTotal = CapacidadeTotal;
            this.NumeroSala = NumeroSala;
            this.Alunos = Alunos;
        }
    }
}