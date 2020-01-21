namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MasterSummaryBabs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        HasilReview = c.String(),
                        Updating = c.String(),
                        DasarUpdating = c.String(),
                        AcuanUpdating = c.String(),
                        Sebelum = c.String(),
                        Sesudah = c.String(),
                        DasarPenyusunan = c.String(),
                        BabId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MasterSummarySubBabs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        HasilReview = c.String(),
                        Updating = c.String(),
                        DasarUpdating = c.String(),
                        AcuanUpdating = c.String(),
                        Sebelum = c.String(),
                        Sesudah = c.String(),
                        DasarPenyusunan = c.String(),
                        SubBabId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MasterSummarySubBabs");
            DropTable("dbo.MasterSummaryBabs");
        }
    }
}
