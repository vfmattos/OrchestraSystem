using OrchestraSystem.Models;

namespace OrchestraSystem.Repositorio.Interfaces
{
    public interface ISymphonyRepositorio
    {

        //MÉTODO DE LISTAGEM DE SINFONIAS

        public Task<List<SymphonyModel>> ListarSinfonias();


        //MÉTODO DE ADIÇÃO DE SINFONIAS

        public Task AdicionarSinfonia(SymphonyModel sinfonia);


        //MÉTODO DE BUSCA DE SINFONIAS

        public Task BuscarSinfoniaPorId(int id);


        //MÉTODS DE UPDATE DE SINFONIAS

        public Task AtualizarSinfonia(SymphonyModel sinfonia);


        //MÉTODO DE REMOÇÃO DE SINFONIAS

        public Task RemoverSinfonia(int id);

    }
}
