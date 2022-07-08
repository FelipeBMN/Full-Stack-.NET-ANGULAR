using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetWebApi.API.Data;
using dotnetWebApi.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetWebApi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController: ControllerBase
    {
        private readonly DataContext context;
        
        public EventsController(DataContext context){
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return this.context.Events;
        }

        [HttpGet("{id}")]
        public Event GetById(int id)
        {
            return this.context.Events.FirstOrDefault(evento => evento.EventId == id);
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
