using SistemaDeVentas.Productos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas.Shared
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=SistemaDeVentas.Properties.Settings.sistemadeventasdbConnectionString")
        {
            // Configuraciones adicionales si son necesarias
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Size> Sizes { get; set; }
        // Define DbSets para otras entidades según sea necesario.

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Aquí puedes configurar el modelo. Por ejemplo, si los nombres de tus tablas o columnas no coinciden exactamente con los nombres de tus entidades o propiedades, puedes configurarlos aquí.
            modelBuilder.Entity<Product>().ToTable("products");
            modelBuilder.Entity<Size>().ToTable("sizes");

            // Si decides en algún momento utilizar propiedades de navegación pero sin carga perezosa (sin virtual), puedes configurar las relaciones aquí.
            // Por ejemplo:
            // modelBuilder.Entity<Product>().HasRequired(p => p.Size).WithMany().HasForeignKey(p => p.SizeId);
        }
    }
}
