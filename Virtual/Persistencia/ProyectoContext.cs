using Microsoft.EntityFrameworkCore;
using Modelo.clases;
using Persistencia;

namespace Virtual
{
    public class ProyectoContext : DbContext
    {
        public DbSet<Deducciones> deducciones { get; set; }
        public DbSet<Empleado> empleados { get; set; }
        public DbSet<Sucursal> sucursales { get; set; }
        public DbSet<Configuracion> empresas { get; set; }
        public DbSet<Ingresos> ingresos { get; set; }
        public DbSet<Sueldo> totales { get; set; }

        // Constructor vacio
        public ProyectoContext() : base()
        {

        }

        // Constructor para pasar la conexión al padre
        public ProyectoContext(DbContextOptions<ProyectoContext> opciones)
            : base(opciones)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                switch (ProyectoConfig.PersistenciaDestino)
                {
                    case "SQLServerProyecto":
                        optionsBuilder.UseSqlServer(ProyectoConfig.connectionString);
                        break;
                    case "PostgresProyecto":
                        optionsBuilder.UseNpgsql(ProyectoConfig.connectionString);
                        break;
                    case "memoriaProyecto":
                        optionsBuilder.UseInMemoryDatabase(ProyectoConfig.connectionString);
                        break;
                }
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>()
                .HasOne(mat => mat.Sucursal)
                .WithMany(est => est.Empleados)
                .HasForeignKey(mat => mat.SucursalId);

            modelBuilder.Entity<Ingresos>()
               .HasOne(mat => mat.Empleado)
               .WithOne(est => est.Ingresos)
               .HasForeignKey<Ingresos>(mat => mat.EmpleadoId);

            modelBuilder.Entity<Deducciones>()
               .HasOne(mat => mat.Empleado)
               .WithOne(est => est.Deducciones)
               .HasForeignKey<Deducciones>(mat => mat.EmpleadoId);

            modelBuilder.Entity<Sueldo>()
                .HasOne(mat => mat.Empleado)
                .WithMany(est => est.Sueldos)
                .HasForeignKey(mat => mat.EmpleadoId);
        }
    }
}
