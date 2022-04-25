namespace VetClinicMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_medicine : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MedicineModels", "price", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MedicineModels", "price", c => c.Int(nullable: false));
        }
    }
}
