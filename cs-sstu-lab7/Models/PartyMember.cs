namespace cs_sstu_lab7.Models
{
    public class PartyMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public InivteStaus Status { get; set; }

        public enum InivteStaus
        {
            Agreed, Disagreed
        }
    }
}
