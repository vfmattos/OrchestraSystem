using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrchestraSystem.Data;
using OrchestraSystem.Models;
using OrchestraSystem.Repositorio.Interfaces;

namespace OrchestraSystem.Controllers
{
    public class MusicosController : Controller
    {

        private readonly OrchestraContext _orchestraContext;
        private readonly IMusicoRepositorio _musicoRepositorio;
        
        public MusicosController(OrchestraContext orchestraContext, IMusicoRepositorio musicoRepositorio)
        {
            _orchestraContext = orchestraContext;
            _musicoRepositorio = musicoRepositorio;
        }


        public IActionResult Index()
        {
            var musicos = _musicoRepositorio.ListarMusicos();
            return View(musicos);
        }

        public IActionResult Criar()
        {
            ViewData["Instruments"] = new SelectList(_orchestraContext.Instrument, "Id", "Name");
            return View();
        }

        public IActionResult Ver(int id)
        {
            var musico = _musicoRepositorio.ListarMusicosPorId(id);

            return View(musico);
        }

        [HttpPost]
        public async Task<IActionResult> Criar(MusicoModel musico, List<int> SelectedInstruments)
        {

            if(SelectedInstruments != null)
            {
                musico.Instruments = new List<InstrumentModel>();

                foreach(var instrumentId in SelectedInstruments)
                {
                    var instrument = await _orchestraContext.Instrument.FindAsync(instrumentId);
                    if(instrument != null)
                    {
                        musico.Instruments.Add(instrument);
                    }
                }
            }

            _orchestraContext.Add(musico);
            await _orchestraContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
