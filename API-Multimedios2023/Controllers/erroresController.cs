using API_Multimedios2023.Data;
using API_Multimedios2023.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Multimedios2023.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class erroresController : Controller
    {
        //variable para manejar la referencia de nuestro contexto
        private readonly Contexto dbContext;
        //constructor con parámetros
        public erroresController(Contexto dbContext)
        {
            //la referencia se almacena en la variable dbContext
            this.dbContext = dbContext;
        }


        [HttpGet(Name = "GetError")]
        public IEnumerable<error> Get()
        {
            var errores = this.dbContext.error.ToList();
            return errores;
        }

        [HttpGet("{idError}")]
        public error GetErrorr(int idError)
        {
            var temp = this.dbContext.error.Find(idError);
            return temp;
        }


        [HttpPut("createError")]
        public void CreateError(error Errores)
        {
            Errores.CreatedAt = DateTime.Now;
            this.dbContext.Add(Errores);
            this.dbContext.SaveChanges();
        }

        [HttpDelete("{idError}")]
        public string DeleteError(int idError)
        {
            var temp = this.dbContext.error.Find(idError);

            if (temp != null)
            {
                try
                {
                    this.dbContext.Remove(temp);
                    this.dbContext.SaveChanges();
                    return "Deleted";
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
            return "ID Error: " + idError + ", Not Found";
        }

        [HttpPut("updateError")]
        public void UpdateError(error Errores)
        {

            this.dbContext.Update(Errores);
            this.dbContext.SaveChanges();

        }
    }
}
