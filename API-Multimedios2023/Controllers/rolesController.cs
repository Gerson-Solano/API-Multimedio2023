using API_Multimedios2023.Data;
using API_Multimedios2023.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Multimedios2023.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class rolesController : Controller
    {
        //variable para manejar la referencia de nuestro contexto
        private readonly Contexto dbContext;
        //constructor con parámetros
        public rolesController(Contexto dbContext)
        {
            //la referencia se almacena en la variable dbContext
            this.dbContext = dbContext;
        }


        [HttpGet(Name = "GetRoles")]
        public IEnumerable<roles> Get()
        {
            var listaRoles = this.dbContext.roles.ToList();
            return listaRoles;
        }

        [HttpGet("{idRol}")]
        public roles GetRoles(int idRol)
        {
            var temp = this.dbContext.roles.Find(idRol);
            return temp;
        }

        [HttpPut("createRoles")]
        public void CreateRol(roles Roles)
        {
            Roles.CreatedAt = DateTime.Now;
            Roles.UpdatedAt = Roles.CreatedAt;
            this.dbContext.Add(Roles);
            this.dbContext.SaveChanges();
        }

        [HttpDelete("{idRol}")]
        public void DeleteRol(int idRol)
        {
            var temp = this.dbContext.roles.Find(idRol);

            if (temp != null)
            {
                this.dbContext.Remove(temp);
                this.dbContext.SaveChanges();
            }
        }

        [HttpPut("updateRol")]
        public void UpdateRol(roles Roles)
        {
            Roles.UpdatedAt = DateTime.Now;
            this.dbContext.Update(Roles);
            this.dbContext.SaveChanges();
        }
    }
}
