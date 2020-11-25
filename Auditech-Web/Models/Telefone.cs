using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auditech_Web.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int TipoTelefone { get; set; }
        public string NumTelefone { get; set; }
    }
}