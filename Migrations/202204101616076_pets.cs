namespace VetClinicMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        petId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        onwer = c.String(),
                        note = c.String(),
                        age = c.Int(nullable: false),
                        pet = c.String(),
                    })
                .PrimaryKey(t => t.petId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pets");
        }
    }
}
