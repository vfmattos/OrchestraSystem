using System.Diagnostics.Metrics;

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
        public List<Instrument> Instruments { get; set; }
        public int OrchestraId { get; set; }
        public OrchestraModel? Orchestra { get; set; }
        public List<SymphonyMusicianModel> SymphonyMusicians { get; set; }

    }
}
