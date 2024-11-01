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
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Enderecos);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("Int")
                .IsRequired();
            builder.Property(x => x.Cpf)
                .HasColumnName("Cpf")
                .HasColumnType("VARCHAR")
                .HasMaxLength(11)
                .IsRequired();
            builder.Property(x => x.DataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("DATETIME")
                .IsRequired();
            builder.Property(x => x.UfNascimento)
               .HasColumnName("UfNascimento")
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
