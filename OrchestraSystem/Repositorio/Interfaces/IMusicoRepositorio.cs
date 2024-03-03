using OrchestraSystem.Models;

namespace OrchestraSystem.Repositorio.Interfaces
{
    public interface IMusicoRepositorio
    {

        //MÉTODO DE LISTAGEM DE MUSICOS

        public List<MusicoModel> ListarMusicos();
        public MusicoModel ListarMusicosPorId(int id);


        //MÉTODO DE ADIÇÃO DE MUSICOS

        public Task AdicionarMusico(MusicoModel musico);


        //MÉTODS DE UPDATE DE INSTRUMENTOS

        public Task AtualizarMusico(MusicoModel musico);


        //MÉTODO DE REMOÇÃO DE INSTRUMENTOS

        public Task RemoverMusico(int id);


    }
}
