using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auditech_Web.Models
{
    public class Parametro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float ValorMin { get; set; }
        public float ValorMax { get; set; }
        public float ValorDefault { get; set; }
    }
}