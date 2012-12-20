using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class FuncionarioMap : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Funcionario");
            this.Property(t => t.Id).HasColumnName("IdFuncionario");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Contato_Id).HasColumnName("Contato_Id");
            this.Property(t => t.Codigo).HasColumnName("Codigo");

            // Relationships
            this.HasRequired(t => t.Contato)
                .WithMany(t => t.Funcionarios)
                .HasForeignKey(d => d.Contato_Id);

        }
    }
}
