using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class RacaoMap : EntityTypeConfiguration<Racao>
    {
        public RacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Racao");
            this.Property(t => t.Id).HasColumnName("IdRacao");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.PeriodoValidade).HasColumnName("PeriodoValidade");
            this.Property(t => t.UnidadeMedida_Id).HasColumnName("UnidadeMedida_Id");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");

            // Relationships
            this.HasRequired(t => t.UnidadeMedida)
                .WithMany(t => t.Racaos)
                .HasForeignKey(d => d.UnidadeMedida_Id).WillCascadeOnDelete(false);

        }
    }
}
