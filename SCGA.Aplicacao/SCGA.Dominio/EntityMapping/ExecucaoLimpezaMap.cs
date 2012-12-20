using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class ExecucaoLimpezaMap : EntityTypeConfiguration<ExecucaoLimpeza>
    {
        public ExecucaoLimpezaMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Observacao)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ExecucaoLimpeza");
            this.Property(t => t.Id).HasColumnName("IdExecucaoLimpeza");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Limpeza_Id).HasColumnName("Limpeza_Id");
            this.Property(t => t.Localizacao_Id).HasColumnName("Localizacao_Id");
            this.Property(t => t.Funcionario_Id).HasColumnName("Funcionario_Id");
            this.Property(t => t.DataExecucao).HasColumnName("DataExecucao");
            this.Property(t => t.Observacao).HasColumnName("Observacao");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");

            // Relationships
            this.HasRequired(t => t.Funcionario)
                .WithMany(t => t.ExecucaoLimpezas)
                .HasForeignKey(d => d.Funcionario_Id);
            this.HasRequired(t => t.Limpeza)
                .WithMany(t => t.ExecucaoLimpezas)
                .HasForeignKey(d => d.Limpeza_Id);
            this.HasRequired(t => t.Localizacao)
                .WithMany(t => t.ExecucaoLimpezas)
                .HasForeignKey(d => d.Localizacao_Id);

        }
    }
}
