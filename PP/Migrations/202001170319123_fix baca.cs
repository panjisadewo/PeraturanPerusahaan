namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixbaca : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MasterSubBabs", "Baca", c => c.String());
            AddColumn("dbo.MasterSubBabProcedurs", "Baca", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MasterSubBabProcedurs", "Baca");
            DropColumn("dbo.MasterSubBabs", "Baca");
        }
    }
}
