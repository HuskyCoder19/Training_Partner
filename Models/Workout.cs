using System.ComponentModel.DataAnnotations;

namespace Training_Partner.Models
{
    public class Workout
    {

        public int Id { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Length must be greater than 0")]
        public double Length { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Calories Burnt must be greater than 0")]
        public int CalsBurnt { get; set; }

        public DateTime Date { get; set; } = DateTime.Today;

        [Required]
        [Range(1, 2, ErrorMessage = "Workout type not valid")]
        public int TypeID { get; set; }
    }
}
