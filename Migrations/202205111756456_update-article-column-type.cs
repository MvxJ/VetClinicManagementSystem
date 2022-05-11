namespace VetClinicMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatearticlecolumntype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ArticleModels", "CreateAt", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.ArticleModels", "UpdatedAt", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ArticleModels", "UpdatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ArticleModels", "CreateAt", c => c.DateTime(nullable: false));
        }
    }
}
