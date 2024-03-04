using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

            if (musico == null)
            {
                return NotFound();
            }

            // Consulta para recuperar os instrumentos associados ao músico a partir da tabela de junção
            var instrumentosAssociados = _orchestraContext.Musico
                                                 .Where(m => m.Id == id)
                                                 .SelectMany(m => m.Instruments)
                                                 .ToList();

            // Adicione os instrumentos associados ao músico ao modelo para serem exibidos na view
            musico.Instruments = instrumentosAssociados;

            return View(musico);
        }

        [HttpPost]
        public async Task<IActionResult> Criar(MusicoModel musico, List<int> selectedInstruments)
        {

            if(selectedInstruments != null)
            {
                musico.Instruments = new List<InstrumentModel>();

                foreach(var instrumentId in selectedInstruments)
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
