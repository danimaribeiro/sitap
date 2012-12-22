using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class LoteMap : EntityTypeConfiguration<Lote>
    {
        public LoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Lote");
            this.Property(t => t.Id).HasColumnName("IdLote");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.DataInicio).HasColumnName("DataInicio");
            this.Property(t => t.Duracao).HasColumnName("Duracao");
            this.Property(t => t.FaseCriacao_Id).HasColumnName("FaseCriacao_Id");
            this.Property(t => t.UnidadeMedida_Id).HasColumnName("UnidadeMedida_Id");
            this.Property(t => t.Localizacao_Id).HasColumnName("Localizacao_Id");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");

            // Relationships
            this.HasRequired(t => t.FaseCriacao)
                .WithMany(t => t.Lotes)
                .HasForeignKey(d => d.FaseCriacao_Id).WillCascadeOnDelete(false);
            this.HasRequired(t => t.Localizacao)
                .WithMany(t => t.Lotes)
                .HasForeignKey(d => d.Localizacao_Id).WillCascadeOnDelete(false);
            this.HasRequired(t => t.UnidadeMedida)
                .WithMany(t => t.Lotes)
                .HasForeignKey(d => d.UnidadeMedida_Id).WillCascadeOnDelete(false);

        }
    }
}
