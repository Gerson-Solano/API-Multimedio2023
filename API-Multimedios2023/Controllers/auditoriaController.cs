﻿using API_Multimedios2023.Data;
using API_Multimedios2023.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Multimedios2023.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class auditoriaController : Controller
    {
        //variable para manejar la referencia de nuestro contexto
        private readonly Contexto dbContext;
        //constructor con parámetros
        public auditoriaController(Contexto dbContext)
        {
            //la referencia se almacena en la variable dbContext
            this.dbContext = dbContext;
        }


        [HttpGet(Name = "GetAuditoria")]
        public IEnumerable<auditoria> Get()
        {
            var listaAuditoria = this.dbContext.auditoria.ToList();
            return listaAuditoria;
        }

        [HttpGet("{idAuditoria}")]
        public auditoria GetAuditoria(int idAuditoria)
        {
            var temp = this.dbContext.auditoria.Find(idAuditoria);
            return temp;
        }


        [HttpPut("createAuditoria")]
        public void CreateAuditoria(auditoria au)
        {
            au.CreateDate = DateTime.Now;
            this.dbContext.Add(au);
            this.dbContext.SaveChanges();
        }

        [HttpDelete("{idAuditoria}")]
        public string DeleteAuditoria(int idAuditoria)
        {
            var temp = this.dbContext.auditoria.Find(idAuditoria);

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
            return "ID Auditoria: " + idAuditoria + ", Not Found";
        }

        [HttpPut("updateAuditoria")]
        public void UpdateAuditoria(auditoria au)
        {
            this.dbContext.Update(au);
            this.dbContext.SaveChanges();
        }
    }
}
