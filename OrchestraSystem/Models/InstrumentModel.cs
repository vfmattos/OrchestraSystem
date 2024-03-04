namespace OrchestraSystem.Models
{
    public class InstrumentModel
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public List<MusicoModel> Musicians { get; set; } = new List<MusicoModel>();
    }
}
