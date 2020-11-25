using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auditech_Web.Models
{
    public class TipoUsuario
    {
        public int Id { get; set; }
        public int TipUsuario { get; set; }
        public string descricaoUsuario { get; set; }
    }
}