using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auditech_Web.Models
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public int idTipoUsuario { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime dataNascimento { get; set; }
    }
}