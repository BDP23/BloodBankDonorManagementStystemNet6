using System.ComponentModel.DataAnnotations.Schema;
namespace BloodBankDonorManagementStystem.Web.Data
{
    public class BloodType : BaseEntity
    {
        public int BloodTypeId { get; set; }
        public int NumberOfDays { get; set; }

        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }    
        public int PatientId { get; set; }

        public string Donorid { get; set; }
        public DateTime DateDonated { get; set; }
        public DateTime DateCollected { get; set; }
    }
}
