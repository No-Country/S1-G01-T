using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigiLearn.Models
{
    public class ActividadesView
    {
       [Display(Name = "Nombre de la Actividad")]
        public string Actividad { get; set; }
        [Display(Name = "Fecha de Realizacion")]
        public string Fecha { get; set; }
        public string controlador { get; set; }
        [Display(Name = "ID de Actividad")]
        public int IdActividad { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
    }
}
