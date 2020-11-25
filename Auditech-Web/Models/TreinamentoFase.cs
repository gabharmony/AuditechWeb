using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auditech_Web.Models
{
    public class TreinamentoFase
    {
        public int Id { get; set; }
        public int IdFase { get; set; }
        public int IdResultadoFase { get; set; }
        public string RespostaTreino { get; set; }
        public double ResultadoTreino { get; set; }
        public DateTime dataExecucao { get; set; }
    }
}