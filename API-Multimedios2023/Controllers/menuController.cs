using API_Multimedios2023.Data;
using API_Multimedios2023.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Multimedios2023.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class menuController : Controller
    {
        //variable para manejar la referencia de nuestro contexto
        private readonly Contexto dbContext;
        //constructor con parámetros
        public menuController(Contexto dbContext)
        {
            //la referencia se almacena en la variable dbContext
            this.dbContext = dbContext;
        }


        [HttpGet(Name = "GetMenu")]
        public IEnumerable<menu> Get()
        {
            var listaMenu = this.dbContext.menu.ToList();
            return listaMenu;
        }

        [HttpGet("{idMenu}")]
        public menu GetMenu(int idMenu)
        {
            var temp = this.dbContext.menu.Find(idMenu);
            return temp;
        }


        [HttpPut("createMenu")]
        public void CreateMenu(menu menu)
        {
            menu.CreatedAt = DateTime.Now;
            menu.UpdatedAt = menu.CreatedAt;
            this.dbContext.Add(menu);
            this.dbContext.SaveChanges();
        }

        [HttpDelete("{idMenu}")]
        public string DeleteMenu(int idMenu)
        {
            var temp = this.dbContext.menu.Find(idMenu);

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
            return "ID Menu: " + idMenu + ", Not Found";
        }

        [HttpPut("updateMenu")]
        public string UpdateMenu(menu Menu)
        {
            if (this.dbContext.menu.Find(Menu.IdMenu) != null)
            {
                try
                {
                    Menu.UpdatedAt = DateTime.Now;
                    this.dbContext.Update(Menu);
                    this.dbContext.SaveChanges();
                    return "Updated";
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }

            }
            return "ID Menu: " + Menu.IdMenu + ", Not Found";
        }
    }
}
