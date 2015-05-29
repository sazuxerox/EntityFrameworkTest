namespace EntityFrameworkTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPublicationName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Book", "Publications", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Book", "Publications");
        }
    }
}
