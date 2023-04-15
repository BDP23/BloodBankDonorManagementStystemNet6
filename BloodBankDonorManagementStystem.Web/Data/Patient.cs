namespace BloodBankDonorManagementStystem.Web.Data
{
    public class Patient : BaseEntity
    {
        public int PatientId { get; set; }
        public string? PatientName { get; set;}
        public int DefaultDays { get; set; }
        public DateTime DateVisited { get; set; }

        public DateTime DateDischarged { get; set; }

    }
}
