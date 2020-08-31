namespace Maquina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Files : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Despedidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Despedida1 = c.String(nullable: false),
                        UserId = c.Int(nullable: false),
                        IdiomaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Idiomas", t => t.IdiomaId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.IdiomaId);
            
            CreateTable(
                "dbo.Idiomas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Idioma1 = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Saludoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Saludo1 = c.String(nullable: false),
                        UserId = c.Int(nullable: false),
                        IdiomaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Idiomas", t => t.IdiomaId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.IdiomaId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        user1 = c.String(nullable: false, maxLength: 10),
                        email = c.String(nullable: false, maxLength: 300),
                        password = c.String(nullable: false, maxLength: 10),
                        ConfirmPassword = c.String(nullable: false),
                        nombreFichero = c.String(),
                        foto = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        ContentType = c.String(),
                        Content = c.Binary(),
                        FileType = c.Int(),
                        UserId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Saludoes", "UserId", "dbo.Users");
            DropForeignKey("dbo.Files", "UserId", "dbo.Users");
            DropForeignKey("dbo.Despedidas", "UserId", "dbo.Users");
            DropForeignKey("dbo.Saludoes", "IdiomaId", "dbo.Idiomas");
            DropForeignKey("dbo.Despedidas", "IdiomaId", "dbo.Idiomas");
            DropIndex("dbo.Files", new[] { "UserId" });
            DropIndex("dbo.Saludoes", new[] { "IdiomaId" });
            DropIndex("dbo.Saludoes", new[] { "UserId" });
            DropIndex("dbo.Despedidas", new[] { "IdiomaId" });
            DropIndex("dbo.Despedidas", new[] { "UserId" });
            DropTable("dbo.Files");
            DropTable("dbo.Users");
            DropTable("dbo.Saludoes");
            DropTable("dbo.Idiomas");
            DropTable("dbo.Despedidas");
        }
    }
}
