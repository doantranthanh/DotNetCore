namespace Core.Signup.Entities.POCO.Tariff
{
    public class TariffDetails
    {
        public string Id { get; set; }
        public int TariffId { get; set; }
        public int TariffPlanId { get; set; }
        public int TariffPlanTransferId { get; set; }
        public string ProductChosen { get; set; }
        public int ProductType { get; set; }
        public string CurrentPricePackage { get; set; }
        public string PreviousPricePackage { get; set; }
        public double LineRentalFee { get; set; }
        public double TotalMonthly { get; set; }
        public string CurrentRouterFee { get; set; }
        public string PreviousRouterFee { get; set; }
        public string CurrentRouterPpFee { get; set; }
        public string PreviousRouterPpFee { get; set; }
        public string CurrentTransferFee { get; set; }
        public string PreviousTransferFee { get; set; }
        public string CurrentNewLineFee { get; set; }
        public string PreviousNewLineFee { get; set; }
        public double SavingVsBt { get; set; }
        public int ContractLength { get; set; }
    }
}