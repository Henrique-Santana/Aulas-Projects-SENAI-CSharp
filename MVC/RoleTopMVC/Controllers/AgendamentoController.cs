using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class AgendamentoController : AbstractController
    {
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Agendamento",
                UsuarioNome = ObterUsuarioNomeSession(),
                UsuarioEmail = ObterUsuarioSession()
            });
        }
        public IActionResult Registrar(IFormCollection form)

        {
            Agendamento agendamento = new Agendamento();
                agendamento.Opcional1= form["opcional1"];
                agendamento.Opcional2 = form ["opcional2"];
                agendamento.Endereco = form ["endereco"];
                agendamento.TipoPagamento = form ["modoPagamento"];
                agendamento.TipoEvento = form ["tipoEvento"];

            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Cpf = form["cpf"],
                Telefone = form["telefone"],
                Email = form["email"]
            };
            

            agendamento.cliente = cliente;
            
            if(agendamentoRepository.Inserir(agendamento))
            {
            return View("Sucesso", new RespostaViewModel()
            {
                Mensagem = "Aguarde a aprovação dos nossos administradores",
                NomeView = "Sucesso",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
            }
            else
            {
            return View("Erro", new RespostaViewModel()
            {
                Mensagem = "Houve um erro ao processar seu pedido. tentefazer novamente",
                NomeView = "Erro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
            }
        }
    }
}