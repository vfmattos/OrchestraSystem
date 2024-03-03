using Microsoft.EntityFrameworkCore;
using OrchestraSystem.Data;
using OrchestraSystem.Models;
using OrchestraSystem.Repositorio.Interfaces;

namespace OrchestraSystem.Repositorio
{
    public class InstrumentRepositorio : IInstrumentRepositorio
    {

        //INJEÇÃO DE DEPENDÊNCIA PARA O BANCO DE DADOS

        private readonly OrchestraContext _orchestraContext;

        public InstrumentRepositorio(OrchestraContext orchestraContext)
        {
            _orchestraContext = orchestraContext;
        }

        public async Task AdicionarInstrumento(InstrumentModel instrument)
        {
           await _orchestraContext.AddAsync(instrument);
            await _orchestraContext.SaveChangesAsync();
        }

        public async Task AtualizarInstrumento(InstrumentModel instrument)
        {
            throw new NotImplementedException();
        }

        public async Task BuscarInstrumentoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<InstrumentModel>> ListarInstrumentos()
        {
            return await _orchestraContext.Instrument.ToListAsync();
        }

        public async Task RemoverInstrumento(int id)
        {
            throw new NotImplementedException();
        }
    }
}
