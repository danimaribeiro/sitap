using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class ExameMap : EntityTypeConfiguration<Exame>
    {
        public ExameMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Observacao)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Exame");
            this.Property(t => t.Id).HasColumnName("IdExame");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Animal_Id).HasColumnName("Animal_Id");
            this.Property(t => t.Doenca_Id).HasColumnName("Doenca_Id");
            this.Property(t => t.DataExame).HasColumnName("DataExame");
            this.Property(t => t.Resultado).HasColumnName("Resultado");
            this.Property(t => t.Observacao).HasColumnName("Observacao");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");

            // Relationships
            this.HasRequired(t => t.Animal)
                .WithMany(t => t.Exames)
                .HasForeignKey(d => d.Animal_Id);
            this.HasRequired(t => t.Doenca)
                .WithMany(t => t.Exames)
                .HasForeignKey(d => d.Doenca_Id);

        }
    }
}
