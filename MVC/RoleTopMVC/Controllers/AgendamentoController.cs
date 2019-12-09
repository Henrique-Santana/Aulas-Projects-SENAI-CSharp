using System;
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
        Agendamento agendamento = new Agendamento();
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
            Evento evento = new Evento(){
                
                Opcional1= form["opcional1"],
                Opcional2 = form ["opcional2"],
                Endereco = form ["endereco"],
                TipoPagamento = form ["tipoPagamento"],
                TipoEvento = form ["tipoEvento"],
                Data = DateTime.Parse(form ["data"])
                };

            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Cpf = form["cpf"],
                Telefone = form["telefone"],
                Email = form["email"]
            };
            

            agendamento.cliente = cliente;
            agendamento.DatadoPedido = DateTime.Now;
            agendamento.evento = evento;
            
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
                Mensagem = "Houve um erro ao processar seu agendamento. tente novamente",
                NomeView = "Erro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
            }
        }
    }
}