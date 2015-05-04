namespace PSBR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Composicao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 100),
                        Extrato_Id = c.Int(),
                        Paciente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Extrato", t => t.Extrato_Id)
                .ForeignKey("dbo.Paciente", t => t.Paciente_Id)
                .Index(t => t.Extrato_Id)
                .Index(t => t.Paciente_Id);
            
            CreateTable(
                "dbo.Extrato",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeDoArquivo = c.String(maxLength: 100),
                        IndImportado = c.Byte(nullable: false),
                        DataHora = c.DateTime(nullable: false),
                        DataReferencia = c.DateTime(nullable: false),
                        Responsavel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Responsavel", t => t.Responsavel_Id)
                .Index(t => t.Responsavel_Id);
            
            CreateTable(
                "dbo.Responsavel",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100),
                        CpfCnpj = c.String(nullable: false, maxLength: 14),
                        NumeroConselho = c.Int(nullable: false),
                        UfConselhoRegional = c.Int(nullable: false),
                        ConselhoRegional_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ConselhoRegional", t => t.ConselhoRegional_Id, cascadeDelete: true)
                .ForeignKey("dbo.Usuario", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.ConselhoRegional_Id);
            
            CreateTable(
                "dbo.ConselhoRegional",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sigla = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Secao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                        Composicao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Composicao", t => t.Composicao_Id)
                .Index(t => t.Composicao_Id);
            
            CreateTable(
                "dbo.Entrada",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 2000),
                        Secao_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Secao", t => t.Secao_Id)
                .Index(t => t.Secao_Id);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Cpf = c.String(nullable: false, maxLength: 14),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Composicao", "Paciente_Id", "dbo.Paciente");
            DropForeignKey("dbo.Entrada", "Secao_Id", "dbo.Secao");
            DropForeignKey("dbo.Secao", "Composicao_Id", "dbo.Composicao");
            DropForeignKey("dbo.Responsavel", "Id", "dbo.Usuario");
            DropForeignKey("dbo.Extrato", "Responsavel_Id", "dbo.Responsavel");
            DropForeignKey("dbo.Responsavel", "ConselhoRegional_Id", "dbo.ConselhoRegional");
            DropForeignKey("dbo.Composicao", "Extrato_Id", "dbo.Extrato");
            DropIndex("dbo.Entrada", new[] { "Secao_Id" });
            DropIndex("dbo.Secao", new[] { "Composicao_Id" });
            DropIndex("dbo.Responsavel", new[] { "ConselhoRegional_Id" });
            DropIndex("dbo.Responsavel", new[] { "Id" });
            DropIndex("dbo.Extrato", new[] { "Responsavel_Id" });
            DropIndex("dbo.Composicao", new[] { "Paciente_Id" });
            DropIndex("dbo.Composicao", new[] { "Extrato_Id" });
            DropTable("dbo.Paciente");
            DropTable("dbo.Entrada");
            DropTable("dbo.Secao");
            DropTable("dbo.Usuario");
            DropTable("dbo.ConselhoRegional");
            DropTable("dbo.Responsavel");
            DropTable("dbo.Extrato");
            DropTable("dbo.Composicao");
        }
    }
}
