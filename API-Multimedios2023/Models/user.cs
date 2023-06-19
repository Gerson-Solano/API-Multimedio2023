using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Multimedios2023.Models
{
    public class user
    {
        [Key]
        [Required]
        public int idUser { get; set; }

        [Required]
        public string idPersonal { get; set; }

        [Required]
        public string NameUser { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [ForeignKey("roles")]
        [Required]
        public int idRol { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public int Enabled { get; set; }

        [Required]
        public DateTime UpdateAt { get; set; }

    }
}
