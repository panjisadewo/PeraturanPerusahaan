namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qwue : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MasterAktivitas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nama = c.String(),
                        Percent = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MasterAktivitas");
        }
    }
}
