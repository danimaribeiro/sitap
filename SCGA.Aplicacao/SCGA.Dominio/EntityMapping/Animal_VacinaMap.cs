using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class Animal_VacinaMap : EntityTypeConfiguration<Animal_Vacina>
    {
        public Animal_VacinaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Animal_Id, t.Vacina_Id });

            // Properties
            this.Property(t => t.Animal_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Vacina_Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Observacao)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Animal_Vacina");
            this.Property(t => t.Animal_Id).HasColumnName("Animal_Id");
            this.Property(t => t.Vacina_Id).HasColumnName("Vacina_Id");
            this.Property(t => t.DataVacinacao).HasColumnName("DataVacinacao");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");
            this.Property(t => t.Veterinario_Id).HasColumnName("Veterinario_Id");
            this.Property(t => t.Observacao).HasColumnName("Observacao");

            // Relationships
            this.HasRequired(t => t.Animal)
                .WithMany(t => t.Animal_Vacina)
                .HasForeignKey(d => d.Animal_Id);
            this.HasRequired(t => t.Vacina)
                .WithMany(t => t.Animal_Vacina)
                .HasForeignKey(d => d.Vacina_Id);
            this.HasRequired(t => t.Veterinario)
                .WithMany(t => t.Animal_Vacina)
                .HasForeignKey(d => d.Veterinario_Id);

        }
    }
}
