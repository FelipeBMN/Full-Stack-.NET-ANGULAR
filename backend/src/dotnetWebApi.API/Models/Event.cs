using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetWebApi.API.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Local { get; set; }
        public string DataEvent { get; set; }
        public string Tema { get; set; }
        public int Quantidade { get; set; }
        public string Lote { get; set; }
        public string ImagemURL { get; set; }
    }
}