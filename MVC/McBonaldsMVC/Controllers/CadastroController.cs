using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class CadastroController : Controller
    {

        ClienteRepository clienteRepositorio = new ClienteRepository();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            //
            ViewData["Action"] = "Cadatro";
            try
            {
                //objeto criado e construtor criado para podemos criar um cliente.
                Cliente cliente = new Cliente(form["nome"], form["endereço"],form["telefone"],form["senha"], form["email"], DateTime.Parse(form["data-nascimento"]));

                clienteRepositorio.Inserir(cliente);
                
                return View("Sucesso");
                //Retorna uma View Erro que na vdd é um File em View/Shared, que retorna uma msg de sucesso.
            }
            catch (Exception e)
            {
                //Retorna uma View Erro que na vdd é um File em View/Shared, que retorna uma msg de erro.
                return View("Erro");
            }
        }
    }
}