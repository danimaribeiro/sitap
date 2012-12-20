using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class VeterinarioMap : EntityTypeConfiguration<Veterinario>
    {
        public VeterinarioMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Crmv)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Telefone)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Veterinario");
            this.Property(t => t.Id).HasColumnName("IdVeterinario");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Crmv).HasColumnName("Crmv");
            this.Property(t => t.Telefone).HasColumnName("Telefone");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");
        }
    }
}
