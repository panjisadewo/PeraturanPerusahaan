namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kqlk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MasterBabs", "RejectKomenProgress", c => c.String());
            AddColumn("dbo.MasterBabs", "RejectKomenTarget", c => c.String());
            AddColumn("dbo.MasterBabs", "ApproveKomenProgress", c => c.String());
            AddColumn("dbo.MasterBabs", "ApproveKomenTarget", c => c.String());
            AddColumn("dbo.MasterBooks", "KomenProgress", c => c.String());
            AddColumn("dbo.MasterBooks", "KomenTarget", c => c.String());
            AddColumn("dbo.MasterBooks", "RejectKomenProgress", c => c.String());
            AddColumn("dbo.MasterBooks", "RejectKomenTarget", c => c.String());
            AddColumn("dbo.MasterBooks", "ApproveKomenProgress", c => c.String());
            AddColumn("dbo.MasterBooks", "ApproveKomenTarget", c => c.String());
            AddColumn("dbo.MasterSubBabs", "KomenProgress", c => c.String());
            AddColumn("dbo.MasterSubBabs", "KomenTarget", c => c.String());
            AddColumn("dbo.MasterSubBabs", "RejectKomenProgress", c => c.String());
            AddColumn("dbo.MasterSubBabs", "RejectKomenTarget", c => c.String());
            AddColumn("dbo.MasterSubBabs", "ApproveKomenProgress", c => c.String());
            AddColumn("dbo.MasterSubBabs", "ApproveKomenTarget", c => c.String());
            AddColumn("dbo.MasterSubSubBabs", "KomenProgress", c => c.String());
            AddColumn("dbo.MasterSubSubBabs", "KomenTarget", c => c.String());
            AddColumn("dbo.MasterSubSubBabs", "RejectKomenProgress", c => c.String());
            AddColumn("dbo.MasterSubSubBabs", "RejectKomenTarget", c => c.String());
            AddColumn("dbo.MasterSubSubBabs", "ApproveKomenProgress", c => c.String());
            AddColumn("dbo.MasterSubSubBabs", "ApproveKomenTarget", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MasterSubSubBabs", "ApproveKomenTarget");
            DropColumn("dbo.MasterSubSubBabs", "ApproveKomenProgress");
            DropColumn("dbo.MasterSubSubBabs", "RejectKomenTarget");
            DropColumn("dbo.MasterSubSubBabs", "RejectKomenProgress");
            DropColumn("dbo.MasterSubSubBabs", "KomenTarget");
            DropColumn("dbo.MasterSubSubBabs", "KomenProgress");
            DropColumn("dbo.MasterSubBabs", "ApproveKomenTarget");
            DropColumn("dbo.MasterSubBabs", "ApproveKomenProgress");
            DropColumn("dbo.MasterSubBabs", "RejectKomenTarget");
            DropColumn("dbo.MasterSubBabs", "RejectKomenProgress");
            DropColumn("dbo.MasterSubBabs", "KomenTarget");
            DropColumn("dbo.MasterSubBabs", "KomenProgress");
            DropColumn("dbo.MasterBooks", "ApproveKomenTarget");
            DropColumn("dbo.MasterBooks", "ApproveKomenProgress");
            DropColumn("dbo.MasterBooks", "RejectKomenTarget");
            DropColumn("dbo.MasterBooks", "RejectKomenProgress");
            DropColumn("dbo.MasterBooks", "KomenTarget");
            DropColumn("dbo.MasterBooks", "KomenProgress");
            DropColumn("dbo.MasterBabs", "ApproveKomenTarget");
            DropColumn("dbo.MasterBabs", "ApproveKomenProgress");
            DropColumn("dbo.MasterBabs", "RejectKomenTarget");
            DropColumn("dbo.MasterBabs", "RejectKomenProgress");
        }
    }
}
