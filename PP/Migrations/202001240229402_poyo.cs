namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class poyo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MasterBabs", "PercentTarget", c => c.String());
            AddColumn("dbo.MasterBooks", "PercentTarget", c => c.String());
            AddColumn("dbo.MasterSubBabs", "PercentTarget", c => c.String());
            AddColumn("dbo.MasterSubSubBabs", "PercentTarget", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MasterSubSubBabs", "PercentTarget");
            DropColumn("dbo.MasterSubBabs", "PercentTarget");
            DropColumn("dbo.MasterBooks", "PercentTarget");
            DropColumn("dbo.MasterBabs", "PercentTarget");
        }
    }
}
