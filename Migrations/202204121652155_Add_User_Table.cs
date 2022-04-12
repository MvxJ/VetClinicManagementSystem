namespace VetClinicMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_User_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        username = c.String(maxLength: 255),
                        name = c.String(maxLength: 255),
                        surname = c.String(maxLength: 255),
                        role = c.Int(nullable: false),
                        email = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserModels");
        }
    }
}
