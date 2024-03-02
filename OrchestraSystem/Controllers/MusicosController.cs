using Microsoft.AspNetCore.Mvc;

namespace OrchestraSystem.Controllers
{
    public class MusicosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }
    }
}
