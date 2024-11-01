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
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("Int")
                .IsRequired();
            builder.Property(x => x.ClienteId)
                .HasColumnName("ClienteId")
                .HasColumnType("Int")
                .IsRequired();
            builder.Property(x => x.Logradouro)
                .HasColumnName("Logradouro")
                .HasColumnType("VARCHAR")
                .HasMaxLength(500)
                .IsRequired();
            builder.Property(x => x.Bairro)
                .HasColumnName("Bairro")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(x => x.Cidade)
                .HasColumnName("Cidade")
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(x => x.Uf)
                .HasColumnName("Uf")
                .HasColumnType("VARCHAR")
                .HasMaxLength(2)
                .IsRequired();
            builder.Property(x => x.DataCadastro)
                .HasColumnName("DataCadastro")
                .HasColumnType("DATETIME")
                .IsRequired();

        }
    }
}
