using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PP.Models.Master;
using PP.Models.Transaction;
using System.ComponentModel.DataAnnotations;

namespace PP.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Nama Lengkap")]
        public string Nama { get; set; }

        [Display(Name = "Kelompok")]
        public string Kelompok { get; set; }

        [Display(Name = "NPP")]
        public string NPP { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<MasterBook> MasterBook { get; set; }
        public DbSet<MasterBab> MasterBab { get; set; }
        public DbSet<MasterSubBab> MasterSubBab { get; set; }
        public DbSet<MasterSubSubBab> MasterSubSubBab { get; set; }
        public DbSet<MasterKelompok> MasterKelompok { get; set; }
        public DbSet<TransactionTugas> TransactionTugas { get; set; }
        public DbSet<MasterHasilReview> HasilReview { get; set; }
        public DbSet<MasterUpdating> Updateting { get; set; }
        public DbSet<MasterDasarUpdateting> DasarUpdateting { get; set; }
        public DbSet<MasterAcuanUpdateting> AcuanUpdateting { get; set; }
        public DbSet<MasterSummaryBab> MasterSummaryBab { get; set; }
        public DbSet<MasterSummarySubBab> MasterSummarySubBab { get; set; }
        public DbSet<MasterSubSubBabProcedur> MasterSubSubBabProcedur { get; set; }
        public DbSet<MasterSubBabProcedur> MasterSubBabProcedur { get; set; }
        public DbSet<LogUser> LogUser { get; set; }
        public DbSet<MasterAktivitas> MasterAktivitas { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}