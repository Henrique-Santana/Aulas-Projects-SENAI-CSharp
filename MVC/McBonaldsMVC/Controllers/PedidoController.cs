using System;
using System.Collections.Generic;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers.PedidoController
{
    public class PedidoController : Controller 
    {

        PedidoRepository pedidoRepository = new PedidoRepository();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakeRepository shakeRepository = new ShakeRepository();

        public IActionResult Index()
        {
            var hamburgueres = hamburguerRepository.ObterTodos();
            var shake = shakeRepository.ObterTodos();

            PedidoViewModels pedido = new PedidoViewModels(); 
            pedido.Hamburgueres = hamburgueres;
            pedido.Shakes = shake;
            
            return View(pedido);
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