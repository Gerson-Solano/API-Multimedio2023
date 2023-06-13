using API_Multimedios2023.Data;
using API_Multimedios2023.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Multimedios2023.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {

        //variable para manejar la referencia de nuestro contexto
        private readonly Contexto dbContext;
        //constructor con parámetros
        public UserController(Contexto dbContext)
        {
            //la referencia se almacena en la variable dbContext
            this.dbContext = dbContext;
        }
        

        [HttpGet(Name = "user")]
        public IEnumerable<user> Get()
        {
            var listaUsers = this.dbContext.user.ToList();
            return listaUsers;
        }

    }
}
