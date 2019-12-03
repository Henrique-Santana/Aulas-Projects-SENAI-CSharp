using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class LoginController : AbstractController
    {

        private ClienteRepository clienteRepository = new ClienteRepository();
        //private PedidoRepository pedidoRepository = new PedidoRepository();
        [HttpGet]
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
            });
            
        }
    }
}