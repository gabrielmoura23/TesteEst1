using System.Data.Entity.ModelConfiguration;
using IEL.Estagio.Domain.Entities;

namespace IEL.Estagio.Infra.Data.EntityConfig
{
    public class EstudanteConfiguration : EntityTypeConfiguration<Estudante>
    {
        public EstudanteConfiguration()
        {
            HasKey(c => c.EstudanteId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Sobrenome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();

            Ignore(t => t.ResultadoValidacao);

            Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11);
        }
    }
}
