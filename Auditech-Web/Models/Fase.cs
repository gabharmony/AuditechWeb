using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auditech_Web.Models
{
    public class Fase
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public float NumDias { get; set; }
        public float QtdeTreinosHora { get; set; }
        public float IntervaloTreinosHora { get; set; }
        public float PesoTreino { get; set; }
        public float PesoDesafio { get; set; }
        public int IdExercicio { get; set; }
        public int IdTratamento { get; set; }
    }
}