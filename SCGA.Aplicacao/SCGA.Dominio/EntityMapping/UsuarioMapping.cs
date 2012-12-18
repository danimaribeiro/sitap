using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.EntityMapping
{
    public class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            this.HasKey(t => t.Id);
            this.ToTable("Usuarios");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(60);
            this.Property(t => t.Email).HasColumnName("Email").IsRequired().HasMaxLength(50);
            this.Property(t => t.Username).HasColumnName("Username").IsRequired().HasMaxLength(50);
            this.Property(t => t.Senha).HasColumnName("Senha").IsRequired().HasMaxLength(20);
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");
        }
    }
}
