namespace SCGA.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animal",
                c => new
                    {
                        IdAnimal = c.Int(nullable: false, identity: true),
                        Identificacao = c.String(nullable: false, maxLength: 50),
                        DataNascimento = c.DateTime(nullable: false),
                        MorteAbate = c.Boolean(nullable: false),
                        Peso = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Localizacao_Id = c.Int(nullable: false),
                        Nome = c.String(maxLength: 100),
                        FaseCriacao_Id = c.Int(nullable: false),
                        UnidadeMedida_Id = c.Int(nullable: false),
                        Lote_Id = c.Int(nullable: false),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdAnimal)
                .ForeignKey("dbo.FaseCriacao", t => t.FaseCriacao_Id, cascadeDelete: true)
                .ForeignKey("dbo.Localizacao", t => t.Localizacao_Id, cascadeDelete: true)
                .ForeignKey("dbo.Lote", t => t.Lote_Id, cascadeDelete: true)
                .ForeignKey("dbo.UnidadeMedida", t => t.UnidadeMedida_Id, cascadeDelete: true)
                .Index(t => t.FaseCriacao_Id)
                .Index(t => t.Localizacao_Id)
                .Index(t => t.Lote_Id)
                .Index(t => t.UnidadeMedida_Id);
            
            CreateTable(
                "dbo.FaseCriacao",
                c => new
                    {
                        IdFaseCriacao = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 200),
                        TempoCriacao = c.Int(nullable: false),
                        UnidadeMedida_Id = c.Int(nullable: false),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdFaseCriacao)
                .ForeignKey("dbo.UnidadeMedida", t => t.UnidadeMedida_Id)
                .Index(t => t.UnidadeMedida_Id);
            
            CreateTable(
                "dbo.UnidadeMedida",
                c => new
                    {
                        IdUnidadeMedida = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        Sigla = c.String(nullable: false, maxLength: 3),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdUnidadeMedida);
            
            CreateTable(
                "dbo.Lote",
                c => new
                    {
                        IdLote = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 200),
                        DataInicio = c.DateTime(nullable: false),
                        Duracao = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FaseCriacao_Id = c.Int(nullable: false),
                        UnidadeMedida_Id = c.Int(nullable: false),
                        Localizacao_Id = c.Int(nullable: false),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdLote)
                .ForeignKey("dbo.FaseCriacao", t => t.FaseCriacao_Id)
                .ForeignKey("dbo.Localizacao", t => t.Localizacao_Id)
                .ForeignKey("dbo.UnidadeMedida", t => t.UnidadeMedida_Id)
                .Index(t => t.FaseCriacao_Id)
                .Index(t => t.Localizacao_Id)
                .Index(t => t.UnidadeMedida_Id);
            
            CreateTable(
                "dbo.Localizacao",
                c => new
                    {
                        IdLocalizacao = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 200),
                        Local = c.String(nullable: false, maxLength: 200),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdLocalizacao);
            
            CreateTable(
                "dbo.ExecucaoLimpeza",
                c => new
                    {
                        IdExecucaoLimpeza = c.Int(nullable: false, identity: true),
                        Limpeza_Id = c.Int(nullable: false),
                        Localizacao_Id = c.Int(nullable: false),
                        Funcionario_Id = c.Int(nullable: false),
                        DataExecucao = c.DateTime(nullable: false),
                        Observacao = c.String(nullable: false, maxLength: 200),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdExecucaoLimpeza)
                .ForeignKey("dbo.Funcionario", t => t.Funcionario_Id, cascadeDelete: true)
                .ForeignKey("dbo.Limpeza", t => t.Limpeza_Id, cascadeDelete: true)
                .ForeignKey("dbo.Localizacao", t => t.Localizacao_Id, cascadeDelete: true)
                .Index(t => t.Funcionario_Id)
                .Index(t => t.Limpeza_Id)
                .Index(t => t.Localizacao_Id);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        IdFuncionario = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Contato_Id = c.Int(nullable: false),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdFuncionario)
                .ForeignKey("dbo.Contato", t => t.Contato_Id, cascadeDelete: true)
                .Index(t => t.Contato_Id);
            
            CreateTable(
                "dbo.Contato",
                c => new
                    {
                        IdContato = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        TipoContato_Id = c.Int(nullable: false),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdContato)
                .ForeignKey("dbo.TipoContato", t => t.TipoContato_Id, cascadeDelete: true)
                .Index(t => t.TipoContato_Id);
            
            CreateTable(
                "dbo.TipoContato",
                c => new
                    {
                        IdTipoContato = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdTipoContato);
            
            CreateTable(
                "dbo.Limpeza",
                c => new
                    {
                        IdLimpeza = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        DataExecutar = c.DateTime(nullable: false),
                        PeriodoExecutarDias = c.Int(nullable: false),
                        ExecutarMaisUmaVez = c.Boolean(nullable: false),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdLimpeza);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        IdProduto = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        ValorCompra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorVenda = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnidadeMedida_Id = c.Int(nullable: false),
                        Grupo_Id = c.Int(nullable: false),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdProduto)
                .ForeignKey("dbo.Grupo", t => t.Grupo_Id, cascadeDelete: true)
                .ForeignKey("dbo.UnidadeMedida", t => t.UnidadeMedida_Id, cascadeDelete: true)
                .Index(t => t.Grupo_Id)
                .Index(t => t.UnidadeMedida_Id);
            
            CreateTable(
                "dbo.Grupo",
                c => new
                    {
                        IdGrupo = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 200),
                        Sigla = c.String(nullable: false, maxLength: 50),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdGrupo);
            
            CreateTable(
                "dbo.Produto_Racao",
                c => new
                    {
                        Racao_Id = c.Int(nullable: false),
                        Produto_Id = c.Int(nullable: false),
                        QtdePorUnidade = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.Racao_Id, t.Produto_Id })
                .ForeignKey("dbo.Produto", t => t.Produto_Id, cascadeDelete: true)
                .ForeignKey("dbo.Racao", t => t.Racao_Id, cascadeDelete: true)
                .Index(t => t.Produto_Id)
                .Index(t => t.Racao_Id);
            
            CreateTable(
                "dbo.Racao",
                c => new
                    {
                        IdRacao = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 200),
                        PeriodoValidade = c.Int(nullable: false),
                        UnidadeMedida_Id = c.Int(nullable: false),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdRacao)
                .ForeignKey("dbo.UnidadeMedida", t => t.UnidadeMedida_Id)
                .Index(t => t.UnidadeMedida_Id);
            
            CreateTable(
                "dbo.Animal_Vacina",
                c => new
                    {
                        Animal_Id = c.Int(nullable: false),
                        Vacina_Id = c.Int(nullable: false),
                        DataVacinacao = c.DateTime(nullable: false),
                        Veterinario_Id = c.Int(nullable: false),
                        Observacao = c.String(nullable: false, maxLength: 200),
                        Id = c.Int(nullable: false),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.Animal_Id, t.Vacina_Id })
                .ForeignKey("dbo.Animal", t => t.Animal_Id, cascadeDelete: true)
                .ForeignKey("dbo.Vacina", t => t.Vacina_Id, cascadeDelete: true)
                .ForeignKey("dbo.Veterinario", t => t.Veterinario_Id, cascadeDelete: true)
                .Index(t => t.Animal_Id)
                .Index(t => t.Vacina_Id)
                .Index(t => t.Veterinario_Id);
            
            CreateTable(
                "dbo.Vacina",
                c => new
                    {
                        IdVacina = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 200),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdVacina);
            
            CreateTable(
                "dbo.Veterinario",
                c => new
                    {
                        IdVeterinario = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200),
                        Crmv = c.String(nullable: false, maxLength: 50),
                        Telefone = c.String(nullable: false, maxLength: 50),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdVeterinario);
            
            CreateTable(
                "dbo.Exame",
                c => new
                    {
                        IdExame = c.Int(nullable: false, identity: true),
                        Animal_Id = c.Int(nullable: false),
                        Doenca_Id = c.Int(nullable: false),
                        DataExame = c.DateTime(nullable: false),
                        Resultado = c.Boolean(nullable: false),
                        Observacao = c.String(nullable: false, maxLength: 200),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdExame)
                .ForeignKey("dbo.Animal", t => t.Animal_Id, cascadeDelete: true)
                .ForeignKey("dbo.Doenca", t => t.Doenca_Id, cascadeDelete: true)
                .Index(t => t.Animal_Id)
                .Index(t => t.Doenca_Id);
            
            CreateTable(
                "dbo.Doenca",
                c => new
                    {
                        IdDoenca = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 200),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdDoenca);
            
            CreateTable(
                "dbo.PerfilUsuario",
                c => new
                    {
                        IdPerfilUsuario = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 50),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdPerfilUsuario);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Senha = c.String(nullable: false),
                        Sessao = c.String(nullable: false, maxLength: 50),
                        PerfilUsuario_Id = c.Int(nullable: false),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdUsuario)
                .ForeignKey("dbo.PerfilUsuario", t => t.PerfilUsuario_Id, cascadeDelete: true)
                .Index(t => t.PerfilUsuario_Id);
            
            CreateTable(
                "dbo.PerfilUsuarioMenu",
                c => new
                    {
                        IdPerfilUsuarioMenu = c.Int(nullable: false, identity: true),
                        MenuPermitido_Id = c.Int(nullable: false),
                        Perfil_Id = c.Int(nullable: false),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdPerfilUsuarioMenu)
                .ForeignKey("dbo.Menu", t => t.MenuPermitido_Id, cascadeDelete: true)
                .ForeignKey("dbo.PerfilUsuario", t => t.Perfil_Id, cascadeDelete: true)
                .Index(t => t.MenuPermitido_Id)
                .Index(t => t.Perfil_Id);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        IdMenu = c.Int(nullable: false, identity: true),
                        Sequencia = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Imagem = c.String(maxLength: 100),
                        Formulario = c.String(maxLength: 100),
                        MenuPai_Id = c.Int(),
                        Codigo = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        UltimaAtualizacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdMenu)
                .ForeignKey("dbo.Menu", t => t.MenuPai_Id)
                .Index(t => t.MenuPai_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Menu", new[] { "MenuPai_Id" });
            DropIndex("dbo.PerfilUsuarioMenu", new[] { "Perfil_Id" });
            DropIndex("dbo.PerfilUsuarioMenu", new[] { "MenuPermitido_Id" });
            DropIndex("dbo.Usuario", new[] { "PerfilUsuario_Id" });
            DropIndex("dbo.Exame", new[] { "Doenca_Id" });
            DropIndex("dbo.Exame", new[] { "Animal_Id" });
            DropIndex("dbo.Animal_Vacina", new[] { "Veterinario_Id" });
            DropIndex("dbo.Animal_Vacina", new[] { "Vacina_Id" });
            DropIndex("dbo.Animal_Vacina", new[] { "Animal_Id" });
            DropIndex("dbo.Racao", new[] { "UnidadeMedida_Id" });
            DropIndex("dbo.Produto_Racao", new[] { "Racao_Id" });
            DropIndex("dbo.Produto_Racao", new[] { "Produto_Id" });
            DropIndex("dbo.Produto", new[] { "UnidadeMedida_Id" });
            DropIndex("dbo.Produto", new[] { "Grupo_Id" });
            DropIndex("dbo.Contato", new[] { "TipoContato_Id" });
            DropIndex("dbo.Funcionario", new[] { "Contato_Id" });
            DropIndex("dbo.ExecucaoLimpeza", new[] { "Localizacao_Id" });
            DropIndex("dbo.ExecucaoLimpeza", new[] { "Limpeza_Id" });
            DropIndex("dbo.ExecucaoLimpeza", new[] { "Funcionario_Id" });
            DropIndex("dbo.Lote", new[] { "UnidadeMedida_Id" });
            DropIndex("dbo.Lote", new[] { "Localizacao_Id" });
            DropIndex("dbo.Lote", new[] { "FaseCriacao_Id" });
            DropIndex("dbo.FaseCriacao", new[] { "UnidadeMedida_Id" });
            DropIndex("dbo.Animal", new[] { "UnidadeMedida_Id" });
            DropIndex("dbo.Animal", new[] { "Lote_Id" });
            DropIndex("dbo.Animal", new[] { "Localizacao_Id" });
            DropIndex("dbo.Animal", new[] { "FaseCriacao_Id" });
            DropForeignKey("dbo.Menu", "MenuPai_Id", "dbo.Menu");
            DropForeignKey("dbo.PerfilUsuarioMenu", "Perfil_Id", "dbo.PerfilUsuario");
            DropForeignKey("dbo.PerfilUsuarioMenu", "MenuPermitido_Id", "dbo.Menu");
            DropForeignKey("dbo.Usuario", "PerfilUsuario_Id", "dbo.PerfilUsuario");
            DropForeignKey("dbo.Exame", "Doenca_Id", "dbo.Doenca");
            DropForeignKey("dbo.Exame", "Animal_Id", "dbo.Animal");
            DropForeignKey("dbo.Animal_Vacina", "Veterinario_Id", "dbo.Veterinario");
            DropForeignKey("dbo.Animal_Vacina", "Vacina_Id", "dbo.Vacina");
            DropForeignKey("dbo.Animal_Vacina", "Animal_Id", "dbo.Animal");
            DropForeignKey("dbo.Racao", "UnidadeMedida_Id", "dbo.UnidadeMedida");
            DropForeignKey("dbo.Produto_Racao", "Racao_Id", "dbo.Racao");
            DropForeignKey("dbo.Produto_Racao", "Produto_Id", "dbo.Produto");
            DropForeignKey("dbo.Produto", "UnidadeMedida_Id", "dbo.UnidadeMedida");
            DropForeignKey("dbo.Produto", "Grupo_Id", "dbo.Grupo");
            DropForeignKey("dbo.Contato", "TipoContato_Id", "dbo.TipoContato");
            DropForeignKey("dbo.Funcionario", "Contato_Id", "dbo.Contato");
            DropForeignKey("dbo.ExecucaoLimpeza", "Localizacao_Id", "dbo.Localizacao");
            DropForeignKey("dbo.ExecucaoLimpeza", "Limpeza_Id", "dbo.Limpeza");
            DropForeignKey("dbo.ExecucaoLimpeza", "Funcionario_Id", "dbo.Funcionario");
            DropForeignKey("dbo.Lote", "UnidadeMedida_Id", "dbo.UnidadeMedida");
            DropForeignKey("dbo.Lote", "Localizacao_Id", "dbo.Localizacao");
            DropForeignKey("dbo.Lote", "FaseCriacao_Id", "dbo.FaseCriacao");
            DropForeignKey("dbo.FaseCriacao", "UnidadeMedida_Id", "dbo.UnidadeMedida");
            DropForeignKey("dbo.Animal", "UnidadeMedida_Id", "dbo.UnidadeMedida");
            DropForeignKey("dbo.Animal", "Lote_Id", "dbo.Lote");
            DropForeignKey("dbo.Animal", "Localizacao_Id", "dbo.Localizacao");
            DropForeignKey("dbo.Animal", "FaseCriacao_Id", "dbo.FaseCriacao");
            DropTable("dbo.Menu");
            DropTable("dbo.PerfilUsuarioMenu");
            DropTable("dbo.Usuario");
            DropTable("dbo.PerfilUsuario");
            DropTable("dbo.Doenca");
            DropTable("dbo.Exame");
            DropTable("dbo.Veterinario");
            DropTable("dbo.Vacina");
            DropTable("dbo.Animal_Vacina");
            DropTable("dbo.Racao");
            DropTable("dbo.Produto_Racao");
            DropTable("dbo.Grupo");
            DropTable("dbo.Produto");
            DropTable("dbo.Limpeza");
            DropTable("dbo.TipoContato");
            DropTable("dbo.Contato");
            DropTable("dbo.Funcionario");
            DropTable("dbo.ExecucaoLimpeza");
            DropTable("dbo.Localizacao");
            DropTable("dbo.Lote");
            DropTable("dbo.UnidadeMedida");
            DropTable("dbo.FaseCriacao");
            DropTable("dbo.Animal");
        }
    }
}
