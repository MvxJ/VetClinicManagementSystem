namespace VetClinicMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_pet_image : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PetsModels", "image", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PetsModels", "image");
        }
    }
}
