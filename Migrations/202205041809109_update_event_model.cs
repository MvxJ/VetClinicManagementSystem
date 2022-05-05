namespace VetClinicMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_event_model : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EventModels", "phone", c => c.String(maxLength: 255));
            AlterColumn("dbo.EventModels", "email", c => c.String(maxLength: 255));
            AlterColumn("dbo.EventModels", "description", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EventModels", "description", c => c.String());
            AlterColumn("dbo.EventModels", "email", c => c.String());
            AlterColumn("dbo.EventModels", "phone", c => c.String());
        }
    }
}
