using System;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Cadastro"
                // montar o abstract controller
            });
        }

    }
}