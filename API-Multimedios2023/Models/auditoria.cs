using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Multimedios2023.Models
{
    public class auditoria
    {

        [Key]
        public int IdAuditoria { get; set; }
        public string Sentencia { get; set; }
        public string Controller { get; set; }

        [ForeignKey("menu")]
        public int IdMenu { get; set; }
        [ForeignKey("user")]
        public int IdUser { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
