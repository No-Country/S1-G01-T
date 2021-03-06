using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigiLearn.Models
{
    public class Sumas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ActividadId { get; set; }
        [Display(Name = "Juego de Sumas")]
        public string Nombre { get; set; }
        [Required]
        public DateTime FechaRealizacion { get; set; }
        [Required]
        public string ProfesionalId { get; set; }
        [Required]
        public int PacienteId { get; set; }
    }
}
