namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixtanggal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MasterBabs", "TanggalBerlaku", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MasterBabs", "TanggalJatuhTempo", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MasterBooks", "TanggalBerlaku", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MasterBooks", "TanggalJatuhTempo", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MasterSubBabs", "TanggalBerlaku", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MasterSubBabs", "TanggalJatuhTempo", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MasterSubSubBabs", "TanggalBerlaku", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MasterSubSubBabs", "TanggalJatuhTempo", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MasterSubSubBabs", "TanggalJatuhTempo", c => c.DateTime());
            AlterColumn("dbo.MasterSubSubBabs", "TanggalBerlaku", c => c.DateTime());
            AlterColumn("dbo.MasterSubBabs", "TanggalJatuhTempo", c => c.DateTime());
            AlterColumn("dbo.MasterSubBabs", "TanggalBerlaku", c => c.DateTime());
            AlterColumn("dbo.MasterBooks", "TanggalJatuhTempo", c => c.DateTime());
            AlterColumn("dbo.MasterBooks", "TanggalBerlaku", c => c.DateTime());
            AlterColumn("dbo.MasterBabs", "TanggalJatuhTempo", c => c.DateTime());
            AlterColumn("dbo.MasterBabs", "TanggalBerlaku", c => c.DateTime());
        }
    }
}
