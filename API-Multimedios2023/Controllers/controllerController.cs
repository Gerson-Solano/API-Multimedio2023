using API_Multimedios2023.Data;
using API_Multimedios2023.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Multimedios2023.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class controllerController : Controller
    {
        //variable para manejar la referencia de nuestro contexto
        private readonly Contexto dbContext;
        //constructor con parámetros
        public controllerController(Contexto dbContext)
        {
            //la referencia se almacena en la variable dbContext
            this.dbContext = dbContext;
        }


        [HttpGet(Name = "GetController")]
        public IEnumerable<controller> Get()
        {
            var listaController = this.dbContext.controller.ToList();
            return listaController;
        }

        [HttpGet("{idController}")]
        public controller GetController(int idControler)
        {
            var temp = this.dbContext.controller.Find(idControler);
            return temp;
        }


        [HttpPut("createController")]
        public void CreateController(controller control)
        {
            control.CreatedAt = DateTime.Now;
            control.UpdatedAt = control.CreatedAt;
            this.dbContext.Add(control);
            this.dbContext.SaveChanges();
        }

        [HttpDelete("{idController}")]
        public string DeleteController(int idController)
        {
            var temp = this.dbContext.controller.Find(idController);

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
            return "ID Controller: " + idController + ", Not Found";
        }

        [HttpPut("updateController")]
        public string UpdateController(controller Controller)
        {
            if (this.dbContext.controller.Find(Controller.IdController) != null)
            {
                try
                {
                    Controller.UpdatedAt = DateTime.Now;
                    this.dbContext.Update(Controller);
                    this.dbContext.SaveChanges();
                    return "Updated";
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }

            }
            return "ID Controller: " + Controller.IdController + ", Not Found";
        }
    }
}
