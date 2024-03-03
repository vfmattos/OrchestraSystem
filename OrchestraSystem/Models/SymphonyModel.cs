
namespace OrchestraSystem.Models
{
    public class SymphonyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Composer { get; set; }
        public DateTime CreationDate { get; set; }
        public List<InstrumentModel> RequiredInstruments { get; set; }
        
    }
}
