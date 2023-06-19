using System.ComponentModel.DataAnnotations;

namespace API_Multimedios2023.Models
{
    public class controller
    {
        [Key]
        [Required]
        public int IdController { get; set; }

        [Required]
        public string NameControllerView { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        [Required]
        public bool Enabled { get; set; }
    }
}
