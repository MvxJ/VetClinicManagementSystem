namespace VetClinicMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pets_update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pets", "name", c => c.String(maxLength: 255));
            AlterColumn("dbo.Pets", "onwer", c => c.String(maxLength: 255));
            AlterColumn("dbo.Pets", "note", c => c.String(maxLength: 255));
            AlterColumn("dbo.Pets", "pet", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pets", "pet", c => c.String());
            AlterColumn("dbo.Pets", "note", c => c.String());
            AlterColumn("dbo.Pets", "onwer", c => c.String());
            AlterColumn("dbo.Pets", "name", c => c.String());
        }
    }
}
