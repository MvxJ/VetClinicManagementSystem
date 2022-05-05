namespace VetClinicMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_event_model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(maxLength: 255),
                        doctorId = c.Int(nullable: false),
                        petId = c.Int(nullable: false),
                        phone = c.String(),
                        email = c.String(),
                        description = c.String(),
                        from = c.DateTime(nullable: false),
                        to = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EventModels");
        }
    }
}
