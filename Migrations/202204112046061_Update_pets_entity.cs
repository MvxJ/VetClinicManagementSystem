namespace VetClinicMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_pets_entity : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Pets", newName: "PetsModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.PetsModels", newName: "Pets");
        }
    }
}
