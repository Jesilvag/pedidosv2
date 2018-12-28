using Entities.Config;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public class ApplicationDbContext: DbContext
    {

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseLazyLoadingProxies().
                UseSqlServer(@"Server=DEV1\SQLEXPRESS;Database=DB_PEDIDOS;Trusted_Connection=True;User ID=Pruebas;Password=123Fenix;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            new ProductosConfig(modelBuilder.Entity<Producto>());

            new MarcaConfig(modelBuilder.Entity<Marca>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
