using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class ContatoMap : EntityTypeConfiguration<Contato>
    {
        public ContatoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Contato");
            this.Property(t => t.Id).HasColumnName("IdContato");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");
            this.Property(t => t.TipoContato_Id).HasColumnName("TipoContato_Id");

            // Relationships
            this.HasRequired(t => t.TipoContato)
                .WithMany(t => t.Contatoes)
                .HasForeignKey(d => d.TipoContato_Id);

        }
    }
}
