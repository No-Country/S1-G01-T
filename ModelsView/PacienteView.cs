using System;
using System.ComponentModel.DataAnnotations;

namespace DigiLearn.ModelsView
{
    public class PacienteView
    {
        public int PacienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        [Display(Name = "Diagnóstico")]
        public string Diagnostico { get; set; }
        //public Guid ProfesionalId { get; set; }
        [Display(Name = "Fecha de alta")]
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }

    }
}
