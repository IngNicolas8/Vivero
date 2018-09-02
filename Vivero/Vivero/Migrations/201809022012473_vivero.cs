namespace Vivero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vivero : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TipoDeDocumentoViewModels", newName: "TipoDeDocumento");
            RenameColumn(table: "dbo.Cliente", name: "Fecha", newName: "Fecha de nacimiento");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Cliente", name: "Fecha de nacimiento", newName: "Fecha");
            RenameTable(name: "dbo.TipoDeDocumento", newName: "TipoDeDocumentoViewModels");
        }
    }
}
