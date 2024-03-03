using Microsoft.EntityFrameworkCore;
using OrchestraSystem.Data;
using OrchestraSystem.Models;
using OrchestraSystem.Repositorio.Interfaces;

namespace OrchestraSystem.Repositorio
{
    public class SymphonyRepositorio : ISymphonyRepositorio
    {

        //INJEÇÃO DE DEPENDÊNCIA PARA O BANCO DE DADOS

        private readonly OrchestraContext _orchestraContext;

        public SymphonyRepositorio(OrchestraContext orchestraContext)
        {
            _orchestraContext = orchestraContext;
        }

        public async Task AdicionarSinfonia(SymphonyModel sinfonia)
        {
            await _orchestraContext.AddAsync(sinfonia);
            await _orchestraContext.SaveChangesAsync();
        }

        public async Task AtualizarSinfonia(SymphonyModel sinfonia)
        {
            throw new NotImplementedException();
        }

        public async Task BuscarSinfoniaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SymphonyModel>> ListarSinfonias()
        {
            return await _orchestraContext.Symphony.ToListAsync();
        }

        public async Task RemoverSinfonia(int id)
        {
            throw new NotImplementedException();
        }
    }
}
