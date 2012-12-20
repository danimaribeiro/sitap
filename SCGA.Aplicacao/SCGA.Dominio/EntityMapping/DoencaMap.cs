using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class DoencaMap : EntityTypeConfiguration<Doenca>
    {
        public DoencaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Doenca");
            this.Property(t => t.Id).HasColumnName("IdDoenca");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");
        }
    }
}
