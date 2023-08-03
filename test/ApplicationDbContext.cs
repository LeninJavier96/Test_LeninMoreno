using Microsoft.EntityFrameworkCore;
using test.Models;

namespace test
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Maquinaria> Maquinaria { get; set; }

        // Agrega más DbSet para otras entidades
    }
}
