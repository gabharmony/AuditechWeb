using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auditech_Web.Models
{
    public class ResultadoFase
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public double ResultFase { get; set; }
        public DateTime DataTermino { get; set; }
    }
}