namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MasterSubBabProcedurs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nama = c.String(),
                        IsDelete = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MasterSubSubBabProcedurs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nama = c.String(),
                        IsDelete = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.MasterSummaryBabs", "SubSubBabProcedur", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MasterSummaryBabs", "SubSubBabProcedur");
            DropTable("dbo.MasterSubSubBabProcedurs");
            DropTable("dbo.MasterSubBabProcedurs");
        }
    }
}
