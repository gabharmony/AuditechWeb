using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auditech_Web.Models
{
    public class Tratamento
    {
        public int idTratamento { get; set; }
        public DateTime dataInicio { get; set; }
        //public string DataTermino { get; set; }
        public string observacaoTratamento { get; set; }
        //public bool Status { get; set; }
        public int profissionalIdProfissional { get; set; }
        public int pacienteIdPaciente { get; set; }
        public int clinicaIdClinica { get; set; }
    }
}