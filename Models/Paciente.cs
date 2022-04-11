using System;
using System.ComponentModel.DataAnnotations;

namespace DigiLearn.Models
{
    public class Paciente
    {
        [Key]
   
        public int PacienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        //public int DNI { get; set; }
        [Display(Name = "Diagnóstico")]
        public string Diagnostico { get; set; }
        public string ProfesionalId { get; set; }
        [Display(Name = "Fecha de alta")]
        public DateTime FechaCreacion { get; set; }
        public bool Estado { get; set; }

    }
}
