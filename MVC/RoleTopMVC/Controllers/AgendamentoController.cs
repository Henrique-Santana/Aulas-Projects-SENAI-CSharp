using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class AgendamentoController : Controller
    {
        public IActionResult Index()
        {
            return View(new BaseViewModel()
            {
                NomeView = "Agendamento"
            });
        }
    }
}