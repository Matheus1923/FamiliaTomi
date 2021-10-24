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
    public class EniController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public EniController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]

        public List<Eni> Get()
        {
            return Contexto.Enis.ToList();
        }

        [HttpGet("{id}")]

        public Eni Get(int id)
        {
            return Contexto.Enis.First(e => e.IdEni == id);
        }

        [HttpPost]

        public string Post([FromBody] Eni eni)
        {
            try
            {
                eni.IdEni = 0;
                Contexto.Enis.Add(eni);
                Contexto.SaveChanges();
                return "OK";

            }
            catch (Exception e)
            {
                return "Erro" + e.Message;
            }

        }
        [HttpPut]

        public string Put([FromBody] Eni eni)
        {
            try
            {
                Contexto.Enis.Update(eni);
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
