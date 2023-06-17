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
        public DbSet<Models.roles> roles { get; set; }
        public DbSet<Models.menu> menu { get; set; }
        public DbSet<Models.controller> controller { get; set; }
        public DbSet<Models.auditoria> auditoria { get; set; }
        public DbSet<Models.error> error { get; set; }
    }
}
