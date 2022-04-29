using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiLearn.Models
{
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PacienteId { get; set; }
        
        [Required]
        public string Nombre { get; set; }
        
        [Required]
        public string Apellido { get; set; }
        public int Edad { get; set; }
        
        //public int DNI { get; set; }
        
        [Display(Name = "Diagnóstico")]
        public string Diagnostico { get; set; }
        
        [Required]
        public string ProfesionalId { get; set; }
        
        [Required]
        [Display(Name = "Fecha de inicio")]
        public DateTime FechaCreacion { get; set; }
        
        [DefaultValue("activo")]
        public bool Estado { get; set; }

    }
}
