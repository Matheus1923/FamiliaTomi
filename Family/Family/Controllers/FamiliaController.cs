using Family.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliaController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public FamiliaController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]

        public List<Familia> Get()
        {
            return Contexto.Familias.ToList();
        }

        [HttpGet("{id}")]

        public Familia Get(int id)
        {
            return Contexto.Familias.First(e => e.IdFamilia == id);
        }

        [HttpPost]

        public String Post([FromBody] Familia familia)
        {
            try
            {
                familia.IdFamilia = 0;
                Contexto.Familias.Add(familia);
                Contexto.SaveChanges();
                return "ok";
            }
            catch (Exception e)
            {
                return "Erro" + e.Message;
            }
        }

        [HttpPut]

        public String Put([FromBody] Familia familia)
        {
            try
            {
                Contexto.Familias.Add(familia);
                Contexto.SaveChanges();
                return "ok";
            }
            catch (Exception e)
            {
                return "Erro" + e.Message;
            }
        }
    }
}
