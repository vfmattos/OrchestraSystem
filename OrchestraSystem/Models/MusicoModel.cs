
namespace OrchestraSystem.Models
{
    public class MusicoModel
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Idade { get; set; }
        public string? Email { get; set; }
        public string? Nacionalidade { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public List<InstrumentModel> Instruments { get; set; }
        

    }
}
