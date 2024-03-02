using Microsoft.AspNetCore.Mvc;

namespace OrchestraSystem.Controllers
{
    public class InstrumentosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
