namespace Vivero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vivero : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "DNI", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cliente", "DNI");
        }
    }
}
