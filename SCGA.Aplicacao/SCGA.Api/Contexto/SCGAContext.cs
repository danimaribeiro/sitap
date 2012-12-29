using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using SCGA.Dominio.Mapping;
using SCGA.Dominio;

namespace SCGA.Api.Contexto
{
    public class SCGAContext : DbContext
    {
        static SCGAContext()
        {
            Database.SetInitializer<SCGAContext>(null);
        }

        public SCGAContext()
            : base("Name=SCGAContext")
        {
        }

        public DbSet<Animal> Animais { get; set; }
        public DbSet<Animal_Vacina> Animal_Vacina { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Doenca> Doencas { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<ExecucaoLimpeza> ExecucaoLimpezas { get; set; }
        public DbSet<FaseCriacao> FasesCriacao { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Limpeza> Limpezas { get; set; }
        public DbSet<Localizacao> Localizacoes { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<PerfilUsuario> PerfilUsuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Produto_Racao> Produto_Racoes { get; set; }
        public DbSet<Racao> Racoes { get; set; }        
        public DbSet<TipoContato> TipoContatos { get; set; }
        public DbSet<UnidadeMedida> UnidadeMedidas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vacina> Vacinas { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Menu> Menus{ get; set; }
        public DbSet<PerfilUsuarioMenu> MenusPerfilUsuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AnimalMap());
            modelBuilder.Configurations.Add(new Animal_VacinaMap());
            modelBuilder.Configurations.Add(new ContatoMap());
            modelBuilder.Configurations.Add(new DoencaMap());
            modelBuilder.Configurations.Add(new ExameMap());
            modelBuilder.Configurations.Add(new ExecucaoLimpezaMap());
            modelBuilder.Configurations.Add(new FaseCriacaoMap());
            modelBuilder.Configurations.Add(new FuncionarioMap());
            modelBuilder.Configurations.Add(new GrupoMap());
            modelBuilder.Configurations.Add(new LimpezaMap());
            modelBuilder.Configurations.Add(new LocalizacaoMap());
            modelBuilder.Configurations.Add(new LoteMap());
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new PerfilUsuarioMap());
            modelBuilder.Configurations.Add(new PerfilUsuarioMenuMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new Produto_RacaoMap());
            modelBuilder.Configurations.Add(new RacaoMap());            
            modelBuilder.Configurations.Add(new TipoContatoMap());
            modelBuilder.Configurations.Add(new UnidadeMedidaMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new VacinaMap());
            modelBuilder.Configurations.Add(new VeterinarioMap());
        }
    }
}
