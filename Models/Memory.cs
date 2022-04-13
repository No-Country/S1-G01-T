using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigiLearn.Models
{
    public class Memory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ActividadId { get; set; }
        [Required]
        public DateTime FechaRealizacion { get; set; }
        [Required]
        public int ProfesionalId { get; set; }
        [Required]
        public int PacienteId { get; set; }


    }
}
