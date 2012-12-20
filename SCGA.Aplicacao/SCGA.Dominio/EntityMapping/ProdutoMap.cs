using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Produto");
            this.Property(t => t.Id).HasColumnName("IdProduto");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.ValorCompra).HasColumnName("ValorCompra");
            this.Property(t => t.ValorVenda).HasColumnName("ValorVenda");
            this.Property(t => t.UnidadeMedida_Id).HasColumnName("UnidadeMedida_Id");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");
            this.Property(t => t.Grupo_Id).HasColumnName("Grupo_Id");

            // Relationships
            this.HasRequired(t => t.Grupo)
                .WithMany(t => t.Produtoes)
                .HasForeignKey(d => d.Grupo_Id);
            this.HasRequired(t => t.UnidadeMedida)
                .WithMany(t => t.Produtoes)
                .HasForeignKey(d => d.UnidadeMedida_Id);

        }
    }
}
