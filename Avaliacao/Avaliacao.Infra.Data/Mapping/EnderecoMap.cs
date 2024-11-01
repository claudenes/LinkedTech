using Avaliacao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avaliacao.Infra.Data.Mapping
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder) 
        {
            builder.ToTable("Endereco");
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
