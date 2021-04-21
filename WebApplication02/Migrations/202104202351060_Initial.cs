namespace WebApplication02.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        CategoriaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaID);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Endereco = c.String(),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Venda",
                c => new
                    {
                        VendaID = c.Int(nullable: false, identity: true),
                        ProdutoID = c.Int(nullable: false),
                        ClienteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VendaID)
                .ForeignKey("dbo.Cliente", t => t.ClienteID, cascadeDelete: true)
                .ForeignKey("dbo.Produto", t => t.ProdutoID, cascadeDelete: true)
                .Index(t => t.ProdutoID)
                .Index(t => t.ClienteID);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoriaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoID)
                .ForeignKey("dbo.Categoria", t => t.CategoriaID, cascadeDelete: true)
                .Index(t => t.CategoriaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venda", "ProdutoID", "dbo.Produto");
            DropForeignKey("dbo.Produto", "CategoriaID", "dbo.Categoria");
            DropForeignKey("dbo.Venda", "ClienteID", "dbo.Cliente");
            DropIndex("dbo.Produto", new[] { "CategoriaID" });
            DropIndex("dbo.Venda", new[] { "ClienteID" });
            DropIndex("dbo.Venda", new[] { "ProdutoID" });
            DropTable("dbo.Produto");
            DropTable("dbo.Venda");
            DropTable("dbo.Cliente");
            DropTable("dbo.Categoria");
        }
    }
}
