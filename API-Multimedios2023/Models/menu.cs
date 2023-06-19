using System.ComponentModel.DataAnnotations;

namespace API_Multimedios2023.Models
{
    public class menu
    {

        [Key]
        [Required]
        public int IdMenu { get; set; }

        [Required]
        public string NameMenu { get; set; }

        [Required]
        public int IdCatalogoMenu { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        [Required]
        public bool Enabled { get; set; }
    }
}
