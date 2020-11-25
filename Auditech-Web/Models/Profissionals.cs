using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auditech_Web.Models
{
    public class Profissionals
    {
        public int idProfissional { get; set; }
        public string numOrdemProfissional { get; set; }
        public int clinicaIdClinica { get; set; }
        public int usuarioIdUsuario { get; set; }
    }
}