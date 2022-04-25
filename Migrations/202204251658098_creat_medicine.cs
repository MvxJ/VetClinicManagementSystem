namespace VetClinicMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creat_medicine : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MedicineModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 255),
                        category = c.String(maxLength: 255),
                        description = c.String(maxLength: 255),
                        price = c.Int(nullable: false),
                        stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MedicineModels");
        }
    }
}
