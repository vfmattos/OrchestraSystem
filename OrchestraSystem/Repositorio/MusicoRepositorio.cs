using Microsoft.EntityFrameworkCore;
using OrchestraSystem.Data;
using OrchestraSystem.Models;
using OrchestraSystem.Repositorio.Interfaces;
using System.Linq;

namespace OrchestraSystem.Repositorio
{
    public class MusicoRepositorio : IMusicoRepositorio
    {

        //INJEÇÃO DE DEPENDÊNCIA PARA O BANCO DE DADOS

        private readonly OrchestraContext _orchestraContext;

        public MusicoRepositorio(OrchestraContext orchestraContext)
        {
            _orchestraContext = orchestraContext;
        }

        public async Task AdicionarMusico(MusicoModel musico)
        {
            await _orchestraContext.AddAsync(musico);
            await _orchestraContext.SaveChangesAsync();
        }

        public async Task AtualizarMusico(MusicoModel musico)
        {
            throw new NotImplementedException();
        }


        public List<MusicoModel> ListarMusicos()
        {
            return _orchestraContext.Musico.ToList();
        }

        public MusicoModel ListarMusicosPorId(int id)
        {
            var musico = ListarMusicos().FirstOrDefault(x => x.Id == id);

            return (musico);

        }

        public async Task RemoverMusico(int id)
        {
            throw new NotImplementedException();
        }
    }
}
