namespace OrchestraSystem.Models
{
    public class OrchestraModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime CreationDate { get; set; }
        public List<SymphonyModel> Sinfonies { get; set; }
 

    }
}
