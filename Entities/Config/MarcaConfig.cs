using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Entities.Config
{
  public  class MarcaConfig
    {

        public MarcaConfig(EntityTypeBuilder<Marca> builder)
        {
            builder.Property(x=>x.Nombre).HasColumnType("VARCHAR(20)");
            builder.HasKey(x => x.Id);
        
        }
    }
}
