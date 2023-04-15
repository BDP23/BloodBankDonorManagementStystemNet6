using Microsoft.AspNetCore.Identity;

namespace BloodBankDonorManagementStystem.Web.Data
{
    public class BloodDonor : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Donorid { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateRequested { get; set; }

    }
}
