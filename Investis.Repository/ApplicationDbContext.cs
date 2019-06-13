using Investis.DomainModel;
using System;
using System.Data.Entity;

namespace Investis.Identity
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(): base("InvestisCon")
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<tb_Role> tb_Role { get; set; }
        public DbSet<tb_Users> tb_Users { get; set; }
        public DbSet<tb_Banks> tb_Banks { get; set; }
        public DbSet<tb_Beneficiaries> tb_Beneficiaries { get; set; }
        public DbSet<tb_BusinessApplications> tb_BusinessApplications { get; set; }
        public DbSet<tb_BusinessCategory> tb_BusinessCategory { get; set; }
        public DbSet<tb_BusinessOwners> tb_BusinessOwners { get; set; }
        public DbSet<tb_Directors> tb_Directors { get; set; }
        public DbSet<tb_Disbursements> tb_Disbursements { get; set; }
        public DbSet<tb_Guarantors> tb_Guarantors { get; set; }
        public DbSet<tb_InvestmentPackages> tb_InvestmentPackages { get; set; }
        public DbSet<tb_Investors> tb_Investors { get; set; }
        public DbSet<tb_Repayments> tb_Repayments { get; set; }
        public DbSet<tb_Investments> tb_Investments { get; set; }


    }


    
}