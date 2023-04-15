namespace BloodBankDonorManagementStystem.Web.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateDonated { get; set; }
        public DateTime DateCollected { get; set; }
    }
}
