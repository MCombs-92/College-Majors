namespace CollegeCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Classes", "MajorId", c => c.Int());
            CreateIndex("dbo.Classes", "MajorId");
            AddForeignKey("dbo.Classes", "MajorId", "dbo.Majors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classes", "MajorId", "dbo.Majors");
            DropIndex("dbo.Classes", new[] { "MajorId" });
            AlterColumn("dbo.Classes", "MajorId", c => c.Int(nullable: false));
        }
    }
}
