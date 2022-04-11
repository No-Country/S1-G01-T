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
        //public DbSet<Preguntas> Preguntas { get; set; }
        //public DbSet<>  { get; set; }


    }
}
