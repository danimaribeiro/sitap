using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using SCGA.Dominio;
using SCGA.Dominio.EntityMapping;

namespace SCGA.Api.Models
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