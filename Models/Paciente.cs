using System;

namespace DigiLearn.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Diagnostico { get; set; }
        public Guid ProfesionalId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }

    }
}
