using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Multimedios2023.Models
{
    public class error
    {
        [Key]
        [Required]
        public int IdErrores { get; set; }

        [Required]
        public string Sentencia { get; set; }

        [Required]
        public string Controller { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }


        [ForeignKey("user")]
        [Required]
        public int IdUser { get; set; }
       



    }
}
