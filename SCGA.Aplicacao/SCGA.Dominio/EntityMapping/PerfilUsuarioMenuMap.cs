using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class PerfilUsuarioMenuMap : EntityTypeConfiguration<PerfilUsuarioMenu>
    {
        public PerfilUsuarioMenuMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);
            
            // Table & Column Mappings
            this.ToTable("PerfilUsuarioMenu");
            this.Property(t => t.Id).HasColumnName("IdPerfilUsuarioMenu");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");

            this.Property(t => t.MenuPermitido_Id).HasColumnName("MenuPermitido_Id");
            this.Property(t => t.Perfil_Id).HasColumnName("Perfil_Id");            
            this.HasRequired(t => t.MenuPermitido).WithMany(t => t.PerfisUsuario).HasForeignKey(d => d.MenuPermitido_Id);
            this.HasRequired(t => t.Perfil).WithMany(t => t.MenusPerfil).HasForeignKey(d => d.Perfil_Id);
        }
    }
}
