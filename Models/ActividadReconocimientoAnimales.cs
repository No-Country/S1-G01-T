using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigiLearn.Models
{
    public class ActividadReconocimientoAnimales
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ActividadId { get; set; }

        [Display(Name = "Reconocimiento de Animales")]
        public string Nombre { get; set; }

        // ¿Nivel de dificultad de la actividad?

        [Required]
        public DateTime FechaRealizacion { get; set; }
        
        [Required]
        public string ProfesionalId { get; set; }
        
        [Required]
        public int PacienteId { get; set; }
    }
}
