using System.ComponentModel.DataAnnotations;

namespace Training_Partner.Models
{
    public class myLogin
    {
        [Required]
        public string? username { get; set; }

        [Required]
        public string? password { get; set; }

    }
}
