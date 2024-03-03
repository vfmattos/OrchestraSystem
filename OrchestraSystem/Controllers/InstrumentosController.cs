using Microsoft.AspNetCore.Mvc;
using OrchestraSystem.Models;
using OrchestraSystem.Repositorio.Interfaces;

namespace OrchestraSystem.Controllers
{
    public class InstrumentosController : Controller
    {

        private readonly IInstrumentRepositorio _instrumentRepositorio;

        public InstrumentosController(IInstrumentRepositorio instrumentRepositorio)
        {
            _instrumentRepositorio = instrumentRepositorio;
        }

        public async Task<IActionResult> Index()
        {

            var instrumentos = await _instrumentRepositorio.ListarInstrumentos();

            return View(instrumentos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Criar(InstrumentModel instrumento)
        {

            await _instrumentRepositorio.AdicionarInstrumento(instrumento);

            return RedirectToAction("Index");
        }
    }
}
