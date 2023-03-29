using System.ComponentModel.DataAnnotations;

namespace SplitAppAPI.Models
{
    public class Persons
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        public string PersonName { get; set; }
    }
}
