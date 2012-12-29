using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class MenuMap : EntityTypeConfiguration<Menu>
    {
        public MenuMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);
            this.Property(t => t.Formulario)                
                .HasMaxLength(100);
            this.Property(t => t.Imagem)                
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Menu");
            this.Property(t => t.Id).HasColumnName("IdMenu");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Sequencia).HasColumnName("Sequencia");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Formulario).HasColumnName("Formulario");
            this.Property(t => t.Imagem).HasColumnName("Imagem");            
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");

            this.Property(t => t.MenuPai_Id).HasColumnName("MenuPai_Id");
            
            this.HasOptional(t => t.MenuPai)
                .WithMany(t => t.MenusFilhos)
                .HasForeignKey(d => d.MenuPai_Id);
        }
    }
}
