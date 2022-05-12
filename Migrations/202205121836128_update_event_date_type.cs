namespace VetClinicMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_event_date_type : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EventModels", "from", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.EventModels", "to", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EventModels", "to", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EventModels", "from", c => c.DateTime(nullable: false));
        }
    }
}
