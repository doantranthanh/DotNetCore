namespace Core.Signup.Entities.POCO.Prospect
{
    public class ProspectData
    {
        public int CusKey { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PostCodeA { get; set; }
        public string PostCodeB { get; set; }
        public int Brand { get; set; }
        public int CurrentProviderId { get; set; }
        public WcfProductType ProductKey { get; set; }
        public bool IsGas { get; set; }
        public bool IsElectricity { get; set; }
        public string MobileNumber { get; set; }
    }
}
