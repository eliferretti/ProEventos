using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Domain;
//using ProEventos.API.Models;
using ProEventos.Persistence.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProEventos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private readonly ProEventosContext _context;
        public EventosController(ProEventosContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;

        }

        //[HttpGet("{id}/{nome}")]
        //public string GetIdNome(int id, string nome)
        //{
        //    return "Método get id:" + id + " Nome: " + nome;
        //}

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            yield return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }
    
        [HttpPost]
        public string Post()
        {
            return "Método Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Método Put ID = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Método Delete ID = {id}";
        }

    }


}
