using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Multimedios2023.Models
{
    public class roles
    {
        [Key]
        [Required]
        public int IdRol { get; set; }

        [Required]
        public string NameRol { get; set; }

        [ForeignKey("menu")]
        [Required]
        public int IdMenu { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        [Required]
        public bool Enabled { get; set; }
    }
}
