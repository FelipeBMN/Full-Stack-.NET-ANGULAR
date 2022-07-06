using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetWebApi.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetWebApi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {

        public IEnumerable<Event> _event = new Event[]{
                new Event() {
                    EventId = 1,
                    Tema = "Angular 11 e .net 5",
                    Local = "home",
                    Lote = "1° lote",
                    Quantidade = 250,
                    DataEvent = DateTime.Now.AddDays(2).ToString("dd/MM/yyy"),
                    ImagemURL = "Foto.png"
                }, new Event() {
                    EventId = 2,
                    Tema = "Angular 11 e .net 5",
                    Local = "home 2",
                    Lote = "2° lote",
                    Quantidade = 250,
                    DataEvent = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
                    ImagemURL = "Foto.png"
                }
           };

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _event;
        }

        [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return _event.Where(evento => evento.EventId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Example Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Example {id}";
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return $"Example {id}";
        }
    }
}
