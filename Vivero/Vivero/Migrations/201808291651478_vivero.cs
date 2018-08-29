namespace Vivero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vivero : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DepartamentoViewModels", "ProvinciaId_ProvinciaId", "dbo.Provincia");
            DropForeignKey("dbo.Localidad", "DepartamentoId_DepartamentoId", "dbo.DepartamentoViewModels");
            DropIndex("dbo.Localidad", new[] { "DepartamentoId_DepartamentoId" });
            DropIndex("dbo.DepartamentoViewModels", new[] { "ProvinciaId_ProvinciaId" });
            CreateTable(
                "dbo.TipoDeDocumentoes",
                c => new
                    {
                        tipoDeDocumentoId = c.Int(nullable: false, identity: true),
                        TipoDeDocumento = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.tipoDeDocumentoId);
            
            AddColumn("dbo.Cliente", "tipoDeDocumentoId_tipoDeDocumentoId", c => c.Int());
            AddColumn("dbo.Localidad", "ProvinciaId_ProvinciaId", c => c.Int());
            CreateIndex("dbo.Cliente", "tipoDeDocumentoId_tipoDeDocumentoId");
            CreateIndex("dbo.Localidad", "ProvinciaId_ProvinciaId");
            AddForeignKey("dbo.Localidad", "ProvinciaId_ProvinciaId", "dbo.Provincia", "ProvinciaId");
            AddForeignKey("dbo.Cliente", "tipoDeDocumentoId_tipoDeDocumentoId", "dbo.TipoDeDocumentoes", "tipoDeDocumentoId");
            DropColumn("dbo.Localidad", "DepartamentoId_DepartamentoId");
            DropTable("dbo.DepartamentoViewModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DepartamentoViewModels",
                c => new
                    {
                        DepartamentoId = c.Int(nullable: false, identity: true),
                        Departamento = c.String(nullable: false),
                        ProvinciaId_ProvinciaId = c.Int(),
                    })
                .PrimaryKey(t => t.DepartamentoId);
            
            AddColumn("dbo.Localidad", "DepartamentoId_DepartamentoId", c => c.Int());
            DropForeignKey("dbo.Cliente", "tipoDeDocumentoId_tipoDeDocumentoId", "dbo.TipoDeDocumentoes");
            DropForeignKey("dbo.Localidad", "ProvinciaId_ProvinciaId", "dbo.Provincia");
            DropIndex("dbo.Localidad", new[] { "ProvinciaId_ProvinciaId" });
            DropIndex("dbo.Cliente", new[] { "tipoDeDocumentoId_tipoDeDocumentoId" });
            DropColumn("dbo.Localidad", "ProvinciaId_ProvinciaId");
            DropColumn("dbo.Cliente", "tipoDeDocumentoId_tipoDeDocumentoId");
            DropTable("dbo.TipoDeDocumentoes");
            CreateIndex("dbo.DepartamentoViewModels", "ProvinciaId_ProvinciaId");
            CreateIndex("dbo.Localidad", "DepartamentoId_DepartamentoId");
            AddForeignKey("dbo.Localidad", "DepartamentoId_DepartamentoId", "dbo.DepartamentoViewModels", "DepartamentoId");
            AddForeignKey("dbo.DepartamentoViewModels", "ProvinciaId_ProvinciaId", "dbo.Provincia", "ProvinciaId");
        }
    }
}
