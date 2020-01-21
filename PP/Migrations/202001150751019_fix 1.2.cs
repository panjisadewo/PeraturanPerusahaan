namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MasterSummaryBabs", "BabId", c => c.Long());
            AlterColumn("dbo.MasterSummarySubBabs", "SubBabId", c => c.Long());
            CreateIndex("dbo.MasterSummaryBabs", "BabId");
            CreateIndex("dbo.MasterSummarySubBabs", "SubBabId");
            AddForeignKey("dbo.MasterSummaryBabs", "BabId", "dbo.MasterBabs", "Id");
            AddForeignKey("dbo.MasterSummarySubBabs", "SubBabId", "dbo.MasterBabs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MasterSummarySubBabs", "SubBabId", "dbo.MasterBabs");
            DropForeignKey("dbo.MasterSummaryBabs", "BabId", "dbo.MasterBabs");
            DropIndex("dbo.MasterSummarySubBabs", new[] { "SubBabId" });
            DropIndex("dbo.MasterSummaryBabs", new[] { "BabId" });
            AlterColumn("dbo.MasterSummarySubBabs", "SubBabId", c => c.Long(nullable: false));
            AlterColumn("dbo.MasterSummaryBabs", "BabId", c => c.Long(nullable: false));
        }
    }
}
