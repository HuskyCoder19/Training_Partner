using System.ComponentModel.DataAnnotations;

namespace Training_Partner.Models
{
    public class LiftType
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Select exercise")]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
