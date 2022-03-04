namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writer_update_status_dataype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Writers", "WriterStatus", c => c.Boolean(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterStatus", c => c.String(maxLength: 15));
        }
    }
}
