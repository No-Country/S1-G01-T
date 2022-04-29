using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiLearn.Models
{
    public class Frases
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ActividadId { get; set; }
        [Display(Name = "Actividad de Frases")]
        public string Nombre { get; set; }
        [Required]
        public DateTime FechaRealizacion { get; set; }
        [Required]
        public string ProfesionalId { get; set; }
        [Required]
        public int PacienteId { get; set; }
    }
}
