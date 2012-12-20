using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class LocalizacaoMap : EntityTypeConfiguration<Localizacao>
    {
        public LocalizacaoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Local)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Localizacao");
            this.Property(t => t.Id).HasColumnName("IdLocalizacao");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Local).HasColumnName("Local");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");
        }
    }
}
