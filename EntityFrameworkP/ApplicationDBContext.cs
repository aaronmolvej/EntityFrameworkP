using EntityFrameworkP.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Diagnostics;

namespace EntityFrameworkP
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) 
        {

        }
        
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Paso> Pasos { get; set; }
        public DbSet<ArchivoAdjunto> ArchivosAdjuntos { get; set; }
    }
}
