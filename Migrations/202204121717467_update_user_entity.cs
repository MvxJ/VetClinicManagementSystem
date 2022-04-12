namespace VetClinicMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_user_entity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserModels", "password", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserModels", "password");
        }
    }
}
