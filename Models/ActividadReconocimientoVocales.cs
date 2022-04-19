using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiLearn.Models
{
    public class ActividadReconocimientoVocales
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ActividadId { get; set; }
            public DateTime FechaRealizacion { get; set; }
            public string ProfesionalId { get; set; }
            public int PacienteId { get; set; }

    }
}
