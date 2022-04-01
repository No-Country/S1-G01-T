using System;

namespace DigiLearn.Models
{
    public class Respuestas
    {
        public int RespuestaId { get; set; }
        public int PacienteId { get; set; }
        public int Tiempo { get; set; }
        public int Num_correctas { get; set; }
        public int Num_preguntas {get;set;}
        public DateTime Fecha { get; set; }

    }
}
