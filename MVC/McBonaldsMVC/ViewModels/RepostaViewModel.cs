namespace McBonaldsMVC.ViewModels
{
    public class RepostaViewModel : BaseViewModel
    {
        public string Mensagem {get; set;}

        public RepostaViewModel()
        {

        }
        public RepostaViewModel(string Mensagem)
        {
            this.Mensagem = Mensagem;
        }
    }
}