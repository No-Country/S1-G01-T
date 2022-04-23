using DigiLearn.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiLearn.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Respuestas> Respuestas { get; set; }
        public DbSet<DigiLearn.Models.Memory> Memory { get; set; }
        public DbSet<DigiLearn.Models.ActividadReconocimientoAnimales> ActividadReconocimientoAnimales { get; set; }

        public DbSet<DigiLearn.Models.ActividadReconocimientoVocales> ActividadReconocimientoVocales { get; set; }

        public DbSet<DigiLearn.Models.Sumas> Sumas { get; set; }

<<<<<<< HEAD
        public DbSet<ActividadRelacionImagenPalabra> ActividadRelacionImagenPalabra { get; set; }
=======
        public DbSet<DigiLearn.Models.Frases> Frases { get; set; }

>>>>>>> 20c5bf39bf0768ee6b84570db143083ef2668d37
        //public DbSet<Preguntas> Preguntas { get; set; }
        //public DbSet<>  { get; set; }


    }
}
