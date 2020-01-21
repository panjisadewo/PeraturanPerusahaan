namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mastersubsubbabstatusApproved : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MasterSubSubBabs", "statusApproved", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MasterSubSubBabs", "statusApproved");
        }
    }
}
