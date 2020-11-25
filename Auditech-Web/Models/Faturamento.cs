using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auditech_Web.Models
{
    public class Faturamento
    {
        public int Id { get; set; }
        public int IdClinica { get; set; }
        public string NumNF { get; set; }
        public DateTime DtFaturamento { get; set; }
        public int QtdePaciente { get; set; }
        public int QtdeTratamento { get; set; }
        public int QtdeTreinamento { get; set; }
        public double ValorPaciente { get; set; }
        public double ValorTratamento { get; set; }
        public double ValorTreinamento { get; set; }
        public double ValorClinica { get; set; }
        public double ValorTotal { get; set; }
        public double AliqImposto { get; set; }
    }
}