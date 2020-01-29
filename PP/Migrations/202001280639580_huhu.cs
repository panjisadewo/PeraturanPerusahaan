namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class huhu : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MasterBabs", "Pencapaian", c => c.String());
            AlterColumn("dbo.MasterBooks", "Pencapaian", c => c.String());
            AlterColumn("dbo.MasterSubBabs", "Pencapaian", c => c.String());
            AlterColumn("dbo.MasterSubSubBabs", "Pencapaian", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MasterSubSubBabs", "Pencapaian", c => c.Long(nullable: false));
            AlterColumn("dbo.MasterSubBabs", "Pencapaian", c => c.Long(nullable: false));
            AlterColumn("dbo.MasterBooks", "Pencapaian", c => c.Long(nullable: false));
            AlterColumn("dbo.MasterBabs", "Pencapaian", c => c.Long(nullable: false));
        }
    }
}
