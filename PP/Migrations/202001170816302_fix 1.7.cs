namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix17 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MasterBabs", "Baca", c => c.String());
            AddColumn("dbo.MasterBooks", "Baca", c => c.String());
            AddColumn("dbo.MasterSubSubBabs", "Baca", c => c.String());
            DropColumn("dbo.MasterSubBabProcedurs", "Baca");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MasterSubBabProcedurs", "Baca", c => c.String());
            DropColumn("dbo.MasterSubSubBabs", "Baca");
            DropColumn("dbo.MasterBooks", "Baca");
            DropColumn("dbo.MasterBabs", "Baca");
        }
    }
}
