namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lallk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogUsers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Aktivitas = c.String(),
                        TanggalPengerjaan = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LogUsers");
        }
    }
}
