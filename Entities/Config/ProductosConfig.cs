using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Config
{
    public class ProductosConfig
    {
        public ProductosConfig(EntityTypeBuilder<Producto> entityTypeBuilder)
        {
            entityTypeBuilder.Property(x => x.Descripcion).HasMaxLength(255).IsRequired();
            entityTypeBuilder.Property(x => x.Nombre).HasMaxLength(25).IsRequired();
            entityTypeBuilder.Property(x => x.Precio).IsRequired();
            entityTypeBuilder.
                HasOne(x => x.Marca).
                WithMany(x => x.Productos).
                HasForeignKey(x => x.Marca_Id).
                IsRequired();

        }
    }
}
