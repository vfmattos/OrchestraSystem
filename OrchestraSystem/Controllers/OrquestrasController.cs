using Microsoft.AspNetCore.Mvc;

namespace OrchestraSystem.Controllers
{
    public class OrquestrasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
