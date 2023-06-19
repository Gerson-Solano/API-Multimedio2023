using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Multimedios2023.Models
{
    public class auditoria
    {

        [Key]
        [Required]
        public int IdAuditoria { get; set; }

        [Required]
        public string Sentencia { get; set; }

        [Required]
        public string Controller { get; set; }

        [ForeignKey("menu")]
        [Required]
        public int IdMenu { get; set; }

        [ForeignKey("user")]
        [Required]
        public int IdUser { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

    }
}
