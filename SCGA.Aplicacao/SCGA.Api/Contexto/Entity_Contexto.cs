using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using SCGA.Dominio.EntityMapping;
using SCGA.Dominio;

namespace SCGA.Api.Contexto
{
    public class Entity_Contexto : DbContext
    {
        public Entity_Contexto()
            : base("ConexaoBancoDeDados")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioMapping());
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
