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
        public DbSet<Memory> Memory { get; set; }
        public DbSet<ActividadReconocimientoAnimales> ActividadReconocimientoAnimales { get; set; }

        public DbSet<ActividadReconocimientoVocales> ActividadReconocimientoVocales { get; set; }

        public DbSet<Sumas> Sumas { get; set; }

        public DbSet<ActividadRelacionImagenPalabra> ActividadRelacionImagenPalabra { get; set; }
        public DbSet<Frases> Frases { get; set; }
        //public DbSet<Preguntas> Preguntas { get; set; }
        //public DbSet<>  { get; set; }


    }
}
