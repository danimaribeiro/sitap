using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class Produto_RacaoMap : EntityTypeConfiguration<Produto_Racao>
    {
        public Produto_RacaoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Racao_Id, t.Produto_Id });

            // Properties
            this.Property(t => t.Racao_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Produto_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Produto_Racao");
            this.Property(t => t.Racao_Id).HasColumnName("Racao_Id");
            this.Property(t => t.Produto_Id).HasColumnName("Produto_Id");
            this.Property(t => t.QtdePorUnidade).HasColumnName("QtdePorUnidade");

            // Relationships
            this.HasRequired(t => t.Produto)
                .WithMany(t => t.Produto_Racao)
                .HasForeignKey(d => d.Produto_Id);
            this.HasRequired(t => t.Racao)
                .WithMany(t => t.Produto_Racao)
                .HasForeignKey(d => d.Racao_Id);

        }
    }
}
