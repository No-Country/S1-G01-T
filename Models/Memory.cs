using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigiLearn.Models
{
    public class Memory
    {
        [Key]
        public int ActividadId { get; set; }

        public DateTime FechaRealizacion { get; set; }
        public int ProfesionalId { get; set; }
        public int PacienteId { get; set; }


    }
}
