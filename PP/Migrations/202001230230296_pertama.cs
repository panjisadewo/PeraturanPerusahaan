namespace PP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pertama : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MasterAcuanUpdatetings",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nama = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MasterDasarUpdatetings",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nama = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MasterHasilReviews",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nama = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LogUsers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Aktivitas = c.String(),
                        TanggalPengerjaan = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MasterAktivitas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nama = c.String(),
                        Percent = c.String(),
                        Hari = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MasterBabs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        BookId = c.Long(),
                        KelompokId = c.Long(),
                        Dokuments = c.String(),
                        Nama = c.String(),
                        Status = c.String(),
                        Urutan = c.String(),
                        Created = c.String(),
                        UpdateDate = c.String(),
                        Jadwal = c.String(),
                        NoInstruksi = c.String(),
                        TanggalBerlaku = c.DateTime(nullable: false),
                        TanggalJatuhTempo = c.DateTime(nullable: false),
                        TimeLine = c.DateTime(nullable: false),
                        StatusProposal = c.String(),
                        Pencapaian = c.Long(nullable: false),
                        Target = c.Long(nullable: false),
                        KomenProgress = c.String(),
                        KomenTarget = c.String(),
                        RejectKomenProgress = c.String(),
                        RejectKomenTarget = c.String(),
                        ApproveKomenProgress = c.String(),
                        ApproveKomenTarget = c.String(),
                        Baca = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MasterBooks", t => t.BookId)
                .ForeignKey("dbo.MasterKelompoks", t => t.KelompokId)
                .Index(t => t.BookId)
                .Index(t => t.KelompokId);
            
            CreateTable(
                "dbo.MasterBooks",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Dokuments = c.String(),
                        Nama = c.String(),
                        Status = c.String(),
                        Urutan = c.String(),
                        Created = c.String(),
                        UpdateDate = c.String(),
                        Jadwal = c.String(),
                        NoInstruksi = c.String(),
                        TanggalBerlaku = c.DateTime(nullable: false),
                        TanggalJatuhTempo = c.DateTime(nullable: false),
                        TimeLine = c.DateTime(nullable: false),
                        StatusProposal = c.String(),
                        Pencapaian = c.Long(nullable: false),
                        Target = c.Long(nullable: false),
                        KomenProgress = c.String(),
                        KomenTarget = c.String(),
                        RejectKomenProgress = c.String(),
                        RejectKomenTarget = c.String(),
                        ApproveKomenProgress = c.String(),
                        ApproveKomenTarget = c.String(),
                        Baca = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MasterKelompoks",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MasterSubBabs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        BabId = c.Long(),
                        Dokuments = c.String(),
                        Nama = c.String(),
                        Status = c.String(),
                        Urutan = c.String(),
                        Created = c.String(),
                        UpdateDate = c.String(),
                        Jadwal = c.String(),
                        NoInstruksi = c.String(),
                        TanggalBerlaku = c.DateTime(nullable: false),
                        TanggalJatuhTempo = c.DateTime(nullable: false),
                        TimeLine = c.DateTime(nullable: false),
                        StatusProposal = c.String(),
                        Pencapaian = c.Long(nullable: false),
                        Target = c.Long(nullable: false),
                        KomenProgress = c.String(),
                        KomenTarget = c.String(),
                        RejectKomenProgress = c.String(),
                        RejectKomenTarget = c.String(),
                        ApproveKomenProgress = c.String(),
                        ApproveKomenTarget = c.String(),
                        Baca = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MasterBabs", t => t.BabId)
                .Index(t => t.BabId);
            
            CreateTable(
                "dbo.MasterSubBabProcedurs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nama = c.String(),
                        IsDelete = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MasterSubSubBabs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SubBabId = c.Long(),
                        Dokuments = c.String(),
                        statusApproved = c.String(),
                        Nama = c.String(),
                        Status = c.String(),
                        Urutan = c.String(),
                        Created = c.String(),
                        UpdateDate = c.String(),
                        Jadwal = c.String(),
                        NoInstruksi = c.String(),
                        TanggalBerlaku = c.DateTime(nullable: false),
                        TanggalJatuhTempo = c.DateTime(nullable: false),
                        TimeLine = c.DateTime(nullable: false),
                        StatusProposal = c.String(),
                        Pencapaian = c.Long(nullable: false),
                        Target = c.Long(nullable: false),
                        KomenProgress = c.String(),
                        KomenTarget = c.String(),
                        RejectKomenProgress = c.String(),
                        RejectKomenTarget = c.String(),
                        ApproveKomenProgress = c.String(),
                        ApproveKomenTarget = c.String(),
                        Baca = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MasterSubBabs", t => t.SubBabId)
                .Index(t => t.SubBabId);
            
            CreateTable(
                "dbo.MasterSubSubBabProcedurs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nama = c.String(),
                        IsDelete = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MasterSummaryBabs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        HasilReview = c.String(),
                        Updating = c.String(),
                        DasarUpdating = c.String(),
                        AcuanUpdating = c.String(),
                        Sebelum = c.String(),
                        Sesudah = c.String(),
                        DasarPenyusunan = c.String(),
                        BabId = c.Long(),
                        SubSubBabProcedur = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MasterBabs", t => t.BabId)
                .Index(t => t.BabId);
            
            CreateTable(
                "dbo.MasterSummarySubBabs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        HasilReview = c.String(),
                        Updating = c.String(),
                        DasarUpdating = c.String(),
                        AcuanUpdating = c.String(),
                        Sebelum = c.String(),
                        Sesudah = c.String(),
                        DasarPenyusunan = c.String(),
                        SubBabId = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MasterBabs", t => t.SubBabId)
                .Index(t => t.SubBabId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.TransactionTugas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        BookId = c.Long(),
                        BabId = c.Long(),
                        SubBabId = c.Long(),
                        MasterKelompokId = c.Long(),
                        status = c.String(),
                        created = c.String(),
                        update = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MasterBabs", t => t.BabId)
                .ForeignKey("dbo.MasterBooks", t => t.BookId)
                .ForeignKey("dbo.MasterKelompoks", t => t.MasterKelompokId)
                .ForeignKey("dbo.MasterSubBabs", t => t.SubBabId)
                .Index(t => t.BookId)
                .Index(t => t.BabId)
                .Index(t => t.SubBabId)
                .Index(t => t.MasterKelompokId);
            
            CreateTable(
                "dbo.MasterUpdatings",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nama = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Nama = c.String(),
                        Kelompok = c.String(),
                        NPP = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.TransactionTugas", "SubBabId", "dbo.MasterSubBabs");
            DropForeignKey("dbo.TransactionTugas", "MasterKelompokId", "dbo.MasterKelompoks");
            DropForeignKey("dbo.TransactionTugas", "BookId", "dbo.MasterBooks");
            DropForeignKey("dbo.TransactionTugas", "BabId", "dbo.MasterBabs");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.MasterSummarySubBabs", "SubBabId", "dbo.MasterBabs");
            DropForeignKey("dbo.MasterSummaryBabs", "BabId", "dbo.MasterBabs");
            DropForeignKey("dbo.MasterSubSubBabs", "SubBabId", "dbo.MasterSubBabs");
            DropForeignKey("dbo.MasterSubBabs", "BabId", "dbo.MasterBabs");
            DropForeignKey("dbo.MasterBabs", "KelompokId", "dbo.MasterKelompoks");
            DropForeignKey("dbo.MasterBabs", "BookId", "dbo.MasterBooks");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.TransactionTugas", new[] { "MasterKelompokId" });
            DropIndex("dbo.TransactionTugas", new[] { "SubBabId" });
            DropIndex("dbo.TransactionTugas", new[] { "BabId" });
            DropIndex("dbo.TransactionTugas", new[] { "BookId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.MasterSummarySubBabs", new[] { "SubBabId" });
            DropIndex("dbo.MasterSummaryBabs", new[] { "BabId" });
            DropIndex("dbo.MasterSubSubBabs", new[] { "SubBabId" });
            DropIndex("dbo.MasterSubBabs", new[] { "BabId" });
            DropIndex("dbo.MasterBabs", new[] { "KelompokId" });
            DropIndex("dbo.MasterBabs", new[] { "BookId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.MasterUpdatings");
            DropTable("dbo.TransactionTugas");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.MasterSummarySubBabs");
            DropTable("dbo.MasterSummaryBabs");
            DropTable("dbo.MasterSubSubBabProcedurs");
            DropTable("dbo.MasterSubSubBabs");
            DropTable("dbo.MasterSubBabProcedurs");
            DropTable("dbo.MasterSubBabs");
            DropTable("dbo.MasterKelompoks");
            DropTable("dbo.MasterBooks");
            DropTable("dbo.MasterBabs");
            DropTable("dbo.MasterAktivitas");
            DropTable("dbo.LogUsers");
            DropTable("dbo.MasterHasilReviews");
            DropTable("dbo.MasterDasarUpdatetings");
            DropTable("dbo.MasterAcuanUpdatetings");
        }
    }
}
