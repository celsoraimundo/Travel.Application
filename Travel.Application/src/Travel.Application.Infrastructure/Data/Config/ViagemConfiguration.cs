using Travel.Application.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Travel.Application.Infrastructure.Data.Config
{
    public class ViagemConfiguration : IEntityTypeConfiguration<Viagem>
    {
        public void Configure(EntityTypeBuilder<Viagem> builder)
        {
            builder.Property(t => t.NomePassageiro)
                .IsRequired();

            builder.Property(t => t.DataPartida)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(t => t.Origem)
                .IsRequired();

            builder.Property(t => t.Destino)
                .IsRequired();
        }
    }
}
