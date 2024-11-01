using Avaliacao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avaliacao.Infra.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder) 
        {
            builder.ToTable("Cliente");
            //builder.HasKey(x => x.Codigo);
            //builder.Property(x => x.Codigo)
            //    .ValueGeneratedOnAdd()
            //    .HasColumnName("CodAu")
            //    .HasColumnType("Int")
            //    .IsRequired();
            //builder.Property(x => x.Nome)
            //    .HasColumnName("Nome")
            //    .HasColumnType("VARCHAR")
            //    .HasMaxLength(40)
            //    .IsRequired();
            
        }
    }
}
