using Microsoft.EntityFrameworkCore;
using Model.Domain;
using System;

namespace Model
{
    public class ProyectoDbContext : DbContext
    {
        public ProyectoDbContext(DbContextOptions<ProyectoDbContext> options)
            : base(options)
        { 
        
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<PermisoCat> PermisoCat { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
     }
}
