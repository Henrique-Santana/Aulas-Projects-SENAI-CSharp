using System;
using Microsoft.AspNetCore.Mvc;

namespace RoleTopMVC.Controllers
{
    public class CadastroController
    {
        public IActionResult Index()
        {
            return View("index");
        }

        private IActionResult View(string v)
        {
            throw new NotImplementedException();
        }
    }
}