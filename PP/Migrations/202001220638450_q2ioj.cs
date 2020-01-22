namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class q2ioj : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MasterAktivitas", "Hari", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MasterAktivitas", "Hari");
        }
    }
}
