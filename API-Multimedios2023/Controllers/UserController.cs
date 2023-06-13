using API_Multimedios2023.Data;
using API_Multimedios2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

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


        [HttpGet(Name = "GetUsers")]
        public IEnumerable<user> Get()
        {
            var listaUsers = this.dbContext.user.ToList();
            return listaUsers;
        }

        [HttpGet("{idUser}")]
        public user GetUser(int idUser)
        {
            var temp = this.dbContext.user.Find(idUser);
            return temp;
        }

        [HttpPut("create")]
        public void CreateUser(user User)
        {
            User.CreatedAt = DateTime.Now;
            User.UpdateAt = User.CreatedAt;
            this.dbContext.Add(User);
            this.dbContext.SaveChanges();
        }

        [HttpDelete("{idUser}")]
        public void DeleteUser(int idUser)
        {
            var temp = this.dbContext.user.Find(idUser);
            if (temp != null)
            {
                this.dbContext.Remove(temp);
                this.dbContext.SaveChanges();
            }
        }

        [HttpPut("update")]
        public void UpdateUser(user User)
        {
            User.UpdateAt = DateTime.Now;
            this.dbContext.Update(User);
            this.dbContext.SaveChanges();
        }

    }
}
