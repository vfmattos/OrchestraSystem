using Microsoft.AspNetCore.Mvc;

namespace OrchestraSystem.Controllers
{
    public class SinfoniasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
