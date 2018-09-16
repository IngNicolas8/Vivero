namespace Vivero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vivero : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false),
                        descripcion = c.String(),
                        ProductoViewModels_ProductoId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Producto", t => t.ProductoViewModels_ProductoId)
                .Index(t => t.ProductoViewModels_ProductoId);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        EmailId = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(nullable: false),
                        Fechadenacimiento = c.DateTime(name: "Fecha de nacimiento", nullable: false),
                        Telefono = c.String(maxLength: 11),
                        Celular = c.String(maxLength: 13),
                        DNI = c.Int(nullable: false),
                        DomicilioId_DomicilioId = c.Int(),
                        TipoDeDocumentoId_TipoDeDocumentoId = c.Int(),
                    })
                .PrimaryKey(t => t.EmailId)
                .ForeignKey("dbo.Domicilio", t => t.DomicilioId_DomicilioId)
                .ForeignKey("dbo.TipoDeDocumento", t => t.TipoDeDocumentoId_TipoDeDocumentoId)
                .Index(t => t.DomicilioId_DomicilioId)
                .Index(t => t.TipoDeDocumentoId_TipoDeDocumentoId);
            
            CreateTable(
                "dbo.Domicilio",
                c => new
                    {
                        DomicilioId = c.Int(nullable: false, identity: true),
                        Calle = c.String(nullable: false),
                        Nro = c.Int(nullable: false),
                        Barrio = c.String(nullable: false),
                        LocalidadId_LocalidadId = c.Int(),
                    })
                .PrimaryKey(t => t.DomicilioId)
                .ForeignKey("dbo.Localidad", t => t.LocalidadId_LocalidadId)
                .Index(t => t.LocalidadId_LocalidadId);
            
            CreateTable(
                "dbo.Localidad",
                c => new
                    {
                        LocalidadId = c.Int(nullable: false, identity: true),
                        Localidad = c.String(nullable: false),
                        ProvinciaId_ProvinciaId = c.Int(),
                    })
                .PrimaryKey(t => t.LocalidadId)
                .ForeignKey("dbo.Provincia", t => t.ProvinciaId_ProvinciaId)
                .Index(t => t.ProvinciaId_ProvinciaId);
            
            CreateTable(
                "dbo.Provincia",
                c => new
                    {
                        ProvinciaId = c.Int(nullable: false, identity: true),
                        Provincia = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProvinciaId);
            
            CreateTable(
                "dbo.Factura",
                c => new
                    {
                        FacturaId = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Total = c.Single(nullable: false),
                        DetalleId_DetalleId = c.Int(),
                        EmailId_EmailId = c.String(maxLength: 128),
                        LocalId_LocalId = c.Int(),
                    })
                .PrimaryKey(t => t.FacturaId)
                .ForeignKey("dbo.Detalle", t => t.DetalleId_DetalleId)
                .ForeignKey("dbo.Cliente", t => t.EmailId_EmailId)
                .ForeignKey("dbo.Local", t => t.LocalId_LocalId)
                .Index(t => t.DetalleId_DetalleId)
                .Index(t => t.EmailId_EmailId)
                .Index(t => t.LocalId_LocalId);
            
            CreateTable(
                "dbo.Detalle",
                c => new
                    {
                        DetalleId = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        SubTotal = c.Single(nullable: false),
                        ProductoId_ProductoId = c.Int(),
                    })
                .PrimaryKey(t => t.DetalleId)
                .ForeignKey("dbo.Producto", t => t.ProductoId_ProductoId)
                .Index(t => t.ProductoId_ProductoId);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Precio = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoId);
            
            CreateTable(
                "dbo.Local",
                c => new
                    {
                        LocalId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Celular = c.String(maxLength: 13),
                        Telefono = c.String(maxLength: 11),
                        DomicilioId_DomicilioId = c.Int(),
                    })
                .PrimaryKey(t => t.LocalId)
                .ForeignKey("dbo.Domicilio", t => t.DomicilioId_DomicilioId)
                .Index(t => t.DomicilioId_DomicilioId);
            
            CreateTable(
                "dbo.TipoDeDocumento",
                c => new
                    {
                        TipoDeDocumentoId = c.Int(nullable: false, identity: true),
                        TipoDeDocumento = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TipoDeDocumentoId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Cliente", "TipoDeDocumentoId_TipoDeDocumentoId", "dbo.TipoDeDocumento");
            DropForeignKey("dbo.Factura", "LocalId_LocalId", "dbo.Local");
            DropForeignKey("dbo.Local", "DomicilioId_DomicilioId", "dbo.Domicilio");
            DropForeignKey("dbo.Factura", "EmailId_EmailId", "dbo.Cliente");
            DropForeignKey("dbo.Factura", "DetalleId_DetalleId", "dbo.Detalle");
            DropForeignKey("dbo.Detalle", "ProductoId_ProductoId", "dbo.Producto");
            DropForeignKey("dbo.Categoria", "ProductoViewModels_ProductoId", "dbo.Producto");
            DropForeignKey("dbo.Cliente", "DomicilioId_DomicilioId", "dbo.Domicilio");
            DropForeignKey("dbo.Domicilio", "LocalidadId_LocalidadId", "dbo.Localidad");
            DropForeignKey("dbo.Localidad", "ProvinciaId_ProvinciaId", "dbo.Provincia");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Local", new[] { "DomicilioId_DomicilioId" });
            DropIndex("dbo.Detalle", new[] { "ProductoId_ProductoId" });
            DropIndex("dbo.Factura", new[] { "LocalId_LocalId" });
            DropIndex("dbo.Factura", new[] { "EmailId_EmailId" });
            DropIndex("dbo.Factura", new[] { "DetalleId_DetalleId" });
            DropIndex("dbo.Localidad", new[] { "ProvinciaId_ProvinciaId" });
            DropIndex("dbo.Domicilio", new[] { "LocalidadId_LocalidadId" });
            DropIndex("dbo.Cliente", new[] { "TipoDeDocumentoId_TipoDeDocumentoId" });
            DropIndex("dbo.Cliente", new[] { "DomicilioId_DomicilioId" });
            DropIndex("dbo.Categoria", new[] { "ProductoViewModels_ProductoId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.TipoDeDocumento");
            DropTable("dbo.Local");
            DropTable("dbo.Producto");
            DropTable("dbo.Detalle");
            DropTable("dbo.Factura");
            DropTable("dbo.Provincia");
            DropTable("dbo.Localidad");
            DropTable("dbo.Domicilio");
            DropTable("dbo.Cliente");
            DropTable("dbo.Categoria");
        }
    }
}
