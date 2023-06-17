using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Multimedios2023.Models
{
    public class error
    {
        [Key]
        public int IdErrores { get; set; }
        public string Sentencia { get; set; }
        public string Controller { get; set; }
        public DateTime CreatedAt { get; set; }


        [ForeignKey("user")]
        public int IdUser { get; set; }
       



    }
}
