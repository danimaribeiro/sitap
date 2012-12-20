using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SCGA.Dominio.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);
            
            // Properties
            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Senha)
                .IsRequired();

            this.Property(t => t.Sessao)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Usuario");
            this.Property(t => t.Id).HasColumnName("IdUsuario");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Senha).HasColumnName("Senha");
            this.Property(t => t.Codigo).HasColumnName("Codigo");
            this.Property(t => t.Sessao).HasColumnName("Sessao");
            this.Property(t => t.DataCriacao).HasColumnName("DataCriacao");
            this.Property(t => t.UltimaAtualizacao).HasColumnName("UltimaAtualizacao");
            this.Property(t => t.PerfilUsuario_Id).HasColumnName("PerfilUsuario_Id");

            // Relationships
            this.HasRequired(t => t.PerfilUsuario)
                .WithMany(t => t.Usuarios)
                .HasForeignKey(d => d.PerfilUsuario_Id);

        }
    }
}
