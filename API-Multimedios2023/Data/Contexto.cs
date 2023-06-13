using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;
using API_Multimedios2023.Models;


namespace API_Multimedios2023.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Models.user> user { get; set; }
    }
}
