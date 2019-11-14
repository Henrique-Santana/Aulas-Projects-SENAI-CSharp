using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers.PedidoController
{
    public class PedidoController : Controller 
    {

        PedidoRepository pedidoRepository = new PedidoRepository();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        public IActionResult Index()
        {
            var hsmburgueres = hamburguerRepository.ObterTodos();
            
            return View();
        }
        public IActionResult Registrar(IFormCollection form)
        {
            Pedido pedido = new Pedido();

            Shake shake = new Shake();
            shake.Nome = form["shake"];
            shake.Preco = 0.0;

            pedido.Shake = shake;
            
            Hamburguer hamburguer = new Hamburguer(form["hamburguer"], 0.0);

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