namespace Vivero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class viero : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cliente", "Email_Email");
            DropColumn("dbo.Cliente", "Email_Password");
            DropColumn("dbo.Cliente", "Email_RememberMe");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cliente", "Email_RememberMe", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cliente", "Email_Password", c => c.String(nullable: false));
            AddColumn("dbo.Cliente", "Email_Email", c => c.String(nullable: false));
        }
    }
}
