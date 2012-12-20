using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class LimpezaMap : EntityTypeConfiguration<Limpeza>
    {
        public LimpezaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Limpeza");
            this.Property(t => t.Id).HasColumnName("IdLimpeza");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.DataExecutar).HasColumnName("DataExecutar");
            this.Property(t => t.PeriodoExecutarDias).HasColumnName("PeriodoExecutarDias");
            this.Property(t => t.ExecutarMaisUmaVez).HasColumnName("ExecutarMaisUmaVez");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");
        }
    }
}
