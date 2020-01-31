namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class luis : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MasterBabs", "Target", c => c.String());
            AlterColumn("dbo.MasterBooks", "Target", c => c.String());
            AlterColumn("dbo.MasterSubBabs", "Target", c => c.String());
            AlterColumn("dbo.MasterSubSubBabs", "Target", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MasterSubSubBabs", "Target", c => c.Long(nullable: false));
            AlterColumn("dbo.MasterSubBabs", "Target", c => c.Long(nullable: false));
            AlterColumn("dbo.MasterBooks", "Target", c => c.Long(nullable: false));
            AlterColumn("dbo.MasterBabs", "Target", c => c.Long(nullable: false));
        }
    }
}
