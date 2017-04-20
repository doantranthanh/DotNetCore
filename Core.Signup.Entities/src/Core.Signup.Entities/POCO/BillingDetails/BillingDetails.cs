namespace Core.Signup.Entities.POCO.BillingDetails
{
    public class BillingDetails
    {
        public string Id { get; set; }
        public string EbillingCharge { get; set; }
        public string PaperCharge { get; set; }
        public string DirectDebitCharge { get; set; }
        public string ManualPayCharge { get; set; }
    }
}