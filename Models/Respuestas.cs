using System;
using System.ComponentModel.DataAnnotations;

namespace DigiLearn.Models
{
    public class Respuestas
    {
        [Key]
        public int RespuestaId { get; set; }
        public int PacienteId { get; set; }
        public Paciente paciente { get; set; }
        public int Tiempo { get; set; }
        public int Num_correctas { get; set; }
        public int Num_preguntas {get;set;}
        public DateTime Fecha { get; set; }

    }
}
