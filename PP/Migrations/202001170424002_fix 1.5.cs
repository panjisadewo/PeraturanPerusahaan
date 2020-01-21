namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix15 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MasterBabs", "TimeLine", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MasterBooks", "TimeLine", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MasterSubBabs", "TimeLine", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MasterSubSubBabs", "TimeLine", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MasterSubSubBabs", "TimeLine", c => c.DateTime());
            AlterColumn("dbo.MasterSubBabs", "TimeLine", c => c.DateTime());
            AlterColumn("dbo.MasterBooks", "TimeLine", c => c.DateTime());
            AlterColumn("dbo.MasterBabs", "TimeLine", c => c.DateTime());
        }
    }
}
