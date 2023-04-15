using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BloodBankDonorManagementStystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<BloodDonor>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BloodType> BloodTypes { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}