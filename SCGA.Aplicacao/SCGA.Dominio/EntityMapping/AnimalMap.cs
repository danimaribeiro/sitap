using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class AnimalMap : EntityTypeConfiguration<Animal>
    {
        public AnimalMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Identificacao)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Nome)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Animal");
            this.Property(t => t.Id).HasColumnName("IdAnimal");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Identificacao).HasColumnName("Identificacao");
            this.Property(t => t.DataNascimento).HasColumnName("DataNascimento");
            this.Property(t => t.MorteAbate).HasColumnName("MorteAbate");
            this.Property(t => t.Peso).HasColumnName("Peso");
            this.Property(t => t.Localizacao_Id).HasColumnName("Localizacao_Id");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.FaseCriacao_Id).HasColumnName("FaseCriacao_Id");
            this.Property(t => t.UnidadeMedida_Id).HasColumnName("UnidadeMedida_Id");
            this.Property(t => t.Lote_Id).HasColumnName("Lote_Id");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");

            // Relationships
            this.HasRequired(t => t.FaseCriacao)
                .WithMany(t => t.Animals)
                .HasForeignKey(d => d.FaseCriacao_Id);
            this.HasRequired(t => t.Localizacao)
                .WithMany(t => t.Animals)
                .HasForeignKey(d => d.Localizacao_Id);
            this.HasRequired(t => t.Lote)
                .WithMany(t => t.Animals)
                .HasForeignKey(d => d.Lote_Id);
            this.HasRequired(t => t.UnidadeMedida)
                .WithMany(t => t.Animals)
                .HasForeignKey(d => d.UnidadeMedida_Id);

        }
    }
}
