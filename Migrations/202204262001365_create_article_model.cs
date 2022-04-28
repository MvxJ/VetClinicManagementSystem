namespace VetClinicMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_article_model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArticleModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Author = c.String(maxLength: 50),
                        UpdateBy = c.String(),
                        Content = c.String(),
                        Short = c.String(maxLength: 255),
                        CreateAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ArticleModels");
        }
    }
}
