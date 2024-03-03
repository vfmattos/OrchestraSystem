using OrchestraSystem.Models;

namespace OrchestraSystem.Repositorio.Interfaces
{
    public interface IInstrumentRepositorio
    {

        //MÉTODO DE LISTAGEM DE INSTRUMENTOS

        public Task<List<InstrumentModel>> ListarInstrumentos();


        //MÉTODO DE ADIÇÃO DE INSTRUMENTOS

        public Task AdicionarInstrumento(InstrumentModel instrument);


        //MÉTODO DE BUSCA DE INSTRUMENTOS

        public Task BuscarInstrumentoPorId(int id);


        //MÉTODS DE UPDATE DE INSTRUMENTOS

        public Task AtualizarInstrumento(InstrumentModel instrument);


        //MÉTODO DE REMOÇÃO DE INSTRUMENTOS

        public Task RemoverInstrumento(int id);


    }
}
