using System.ComponentModel.DataAnnotations;

namespace cs_sstu_lab7.Models
{
    public class PartyMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [RegularExpression(@"^[\w-_]+(\.[\w!#$%'*+\/=?\^`{|}]+)*@((([\-\w]+\.)+[a-zA-Z]{2,20})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$", ErrorMessage = "Invalid email")]
        public string Email { get; set; }
        public InivteStaus Status { get; set; }

        public enum InivteStaus
        {
            Agreed, Disagreed
        }
    }
}
