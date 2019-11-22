using System;
using System.Collections.Generic;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers.PedidoController
{
    public class PedidoController : AbstractController 
    {

        PedidoRepository pedidoRepository = new PedidoRepository();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakeRepository shakeRepository = new ShakeRepository();

        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index()
        {
            PedidoViewModels pvm = new PedidoViewModels();
            pvm.Hamburgueres = hamburguerRepository.ObterTodos();
            pvm.Shakes = shakeRepository.ObterTodos();

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if (!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                pvm.NomeUsuario = nomeUsuarioLogado;
            }

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if (clienteLogado != null)
            {
                pvm.Cliente = clienteLogado;
            }
            
            return View(pvm);
        }
        public IActionResult Registrar(IFormCollection form)
        {
            Pedido pedido = new Pedido();

            Shake shake = new Shake();
            var nomeShake = form["shake"];
            shake.Nome = nomeShake;
            shake.Preco = shakeRepository.ObterPrecoDe(nomeShake);

            pedido.Shake = shake;
            
            var nomeHamburguer = form["hamburguer"];
            Hamburguer hamburguer = new Hamburguer(nomeHamburguer,hamburguerRepository.ObterPrecoDe(nomeHamburguer));


            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Endereço = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]
            };

            pedido.Cliente = cliente;
        
            pedido.DatadoPedido = DateTime.Now;
            pedido.PrecoTotal = 0.0;
            pedidoRepository.Inserir(pedido);

            return View("Sucesso");
        }
    }
}