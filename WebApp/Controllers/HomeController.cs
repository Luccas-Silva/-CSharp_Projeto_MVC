using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Aula()
        {
            var listAulas = new List<AulaModel>() { 
                new AulaModel { Materia = "CSharp", Turma = "2-ADS" },
                new AulaModel { Materia = "Java", Turma = "2-ADS" },
                new AulaModel { Materia = "Python", Turma = "2-ADS" }
            };

            return View(listAulas);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(AulaModel model)
        {
            if (ModelState.IsValid) { 
                //Salvar dados no banco
                return RedirectToAction("Aula");
            }
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
