using System.ComponentModel.DataAnnotations;

namespace API_Multimedios2023.Models
{
    public class user
    {
        [Key]
        public int idUser { get; set; }
        public string idPersonal { get; set; }
        public string NameUser { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int idRol { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Enabled { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}
