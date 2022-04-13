using System;
using System.ComponentModel.DataAnnotations;

namespace DigiLearn.Models
{
    public class ActividadReconocimientoVocales
    {
            [Key]
            public int ActividadId { get; set; }
            public DateTime FechaRealizacion { get; set; }
            public int ProfesionalId { get; set; }
            public int PacienteId { get; set; }

    }
}
