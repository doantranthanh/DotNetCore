using System.Collections.Generic;
using Core.Signup.Entities.POCO.BillingDetails;
using Core.Signup.Entities.POCO.Tariff;

namespace Core.Signup.XmlDataServices.Tests.FakeData
{
    public class FakeXmlReaderResult
    {
        public static Dictionary<string, List<string>> FakeAllMappingReturn()
        {
            var fakeMappingReturn = new Dictionary<string, List<string>>()
            {
                {"PhoneBroadbandBasix", new List<string>() { "cc_affl" } },
                {"PhoneBroadbandMax", new List<string>() { "ccmax_affl" } },
                {"Fibre40Basix", new List<string>() { "basix_40_affl" } },
                {"Fibre40max", new List<string>() { "max_40_affl" } },
                {"Fibre80Basix", new List<string>() { "basix_80_affl" } },
                {"Fibre80Max", new List<string>() { "max_80_affl" } },
                {"BroadbandBasix", new List<string>() { "bb" } },
                {"BroadbandMax", new List<string>() { "bbmax" } },
                {"PhoneLineBasix", new List<string>() { "tt" } },
                {"PhoneLineMax", new List<string>() { "ttmax" } },
            };
            return fakeMappingReturn;
        }


        public static Dictionary<string, TariffDetails> FakeAllTariffDetailsReturn()
        {
            var fakeReturn = new Dictionary<string, TariffDetails>()
            {
                {"PhoneBroadbandBasix", new TariffDetails() {
                    Id = "PhoneBroadbandBasix",
                    TariffId = 1,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    CurrentPricePackage = "FREE",
                    PreviousPricePackage = "6.50",
                    LineRentalFee = 15.45,
                    TotalMonthly = 15.45,
                    CurrentRouterFee = "FREE",
                    PreviousRouterFee = "35.00",
                    CurrentRouterPpFee = "9.99",
                    PreviousRouterPpFee = string.Empty,
                    CurrentTransferFee = "FREE",
                    PreviousTransferFee = string.Empty,
                    CurrentNewLineFee = "48.00",
                    PreviousNewLineFee = string.Empty,
                    SavingVsBt = 233,
                    ContractLength = 24}
                },
               {"PhoneBroadbandMax", new TariffDetails() {
                    Id = "PhoneBroadbandMax",
                    TariffId = 2,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    CurrentPricePackage = "FREE",
                    PreviousPricePackage = "6.50",
                    LineRentalFee = 15.45,
                    TotalMonthly = 15.45,
                    CurrentRouterFee = "FREE",
                    PreviousRouterFee = "35.00",
                    CurrentRouterPpFee = "9.99",
                    PreviousRouterPpFee = string.Empty,
                    CurrentTransferFee = "FREE",
                    PreviousTransferFee = string.Empty,
                    CurrentNewLineFee = "48.00",
                    PreviousNewLineFee = string.Empty,
                    SavingVsBt = 233,
                    ContractLength = 24}
                },
               {"Fibre40Basix", new TariffDetails() {
                    Id = "Fibre40Basix",
                    TariffId = 3,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    CurrentPricePackage = "FREE",
                    PreviousPricePackage = "6.50",
                    LineRentalFee = 15.45,
                    TotalMonthly = 15.45,
                    CurrentRouterFee = "FREE",
                    PreviousRouterFee = "35.00",
                    CurrentRouterPpFee = "9.99",
                    PreviousRouterPpFee = string.Empty,
                    CurrentTransferFee = "FREE",
                    PreviousTransferFee = string.Empty,
                    CurrentNewLineFee = "48.00",
                    PreviousNewLineFee = string.Empty,
                    SavingVsBt = 233,
                    ContractLength = 24}
                },
               {"Fibre40max", new TariffDetails() {
                    Id = "Fibre40max",
                    TariffId = 4,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    CurrentPricePackage = "FREE",
                    PreviousPricePackage = "6.50",
                    LineRentalFee = 15.45,
                    TotalMonthly = 15.45,
                    CurrentRouterFee = "FREE",
                    PreviousRouterFee = "35.00",
                    CurrentRouterPpFee = "9.99",
                    PreviousRouterPpFee = string.Empty,
                    CurrentTransferFee = "FREE",
                    PreviousTransferFee = string.Empty,
                    CurrentNewLineFee = "48.00",
                    PreviousNewLineFee = string.Empty,
                    SavingVsBt = 233,
                    ContractLength = 24}
                },
               {"Fibre80Basix", new TariffDetails() {
                    Id = "Fibre80Basix",
                    TariffId = 5,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    CurrentPricePackage = "FREE",
                    PreviousPricePackage = "6.50",
                    LineRentalFee = 15.45,
                    TotalMonthly = 15.45,
                    CurrentRouterFee = "FREE",
                    PreviousRouterFee = "35.00",
                    CurrentRouterPpFee = "9.99",
                    PreviousRouterPpFee = string.Empty,
                    CurrentTransferFee = "FREE",
                    PreviousTransferFee = string.Empty,
                    CurrentNewLineFee = "48.00",
                    PreviousNewLineFee = string.Empty,
                    SavingVsBt = 233,
                    ContractLength = 24}
                },
               {"Fibre80Max", new TariffDetails() {
                    Id = "Fibre80Max",
                    TariffId = 6,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    CurrentPricePackage = "FREE",
                    PreviousPricePackage = "6.50",
                    LineRentalFee = 15.45,
                    TotalMonthly = 15.45,
                    CurrentRouterFee = "FREE",
                    PreviousRouterFee = "35.00",
                    CurrentRouterPpFee = "9.99",
                    PreviousRouterPpFee = string.Empty,
                    CurrentTransferFee = "FREE",
                    PreviousTransferFee = string.Empty,
                    CurrentNewLineFee = "48.00",
                    PreviousNewLineFee = string.Empty,
                    SavingVsBt = 233,
                    ContractLength = 24}
                },
               {"BroadbandBasix", new TariffDetails() {
                    Id = "PhoneBroadbandBasix",
                    TariffId = 7,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    CurrentPricePackage = "FREE",
                    PreviousPricePackage = "6.50",
                    LineRentalFee = 15.45,
                    TotalMonthly = 15.45,
                    CurrentRouterFee = "FREE",
                    PreviousRouterFee = "35.00",
                    CurrentRouterPpFee = "9.99",
                    PreviousRouterPpFee = string.Empty,
                    CurrentTransferFee = "FREE",
                    PreviousTransferFee = string.Empty,
                    CurrentNewLineFee = "48.00",
                    PreviousNewLineFee = string.Empty,
                    SavingVsBt = 233,
                    ContractLength = 24}
                },
               {"BroadbandMax", new TariffDetails() {
                    Id = "BroadbandMax",
                    TariffId = 8,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    CurrentPricePackage = "FREE",
                    PreviousPricePackage = "6.50",
                    LineRentalFee = 15.45,
                    TotalMonthly = 15.45,
                    CurrentRouterFee = "FREE",
                    PreviousRouterFee = "35.00",
                    CurrentRouterPpFee = "9.99",
                    PreviousRouterPpFee = string.Empty,
                    CurrentTransferFee = "FREE",
                    PreviousTransferFee = string.Empty,
                    CurrentNewLineFee = "48.00",
                    PreviousNewLineFee = string.Empty,
                    SavingVsBt = 233,
                    ContractLength = 24}
                },
               {"PhoneLineBasix", new TariffDetails() {
                    Id = "PhoneLineBasix",
                    TariffId = 9,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    CurrentPricePackage = "FREE",
                    PreviousPricePackage = "6.50",
                    LineRentalFee = 15.45,
                    TotalMonthly = 15.45,
                    CurrentRouterFee = "FREE",
                    PreviousRouterFee = "35.00",
                    CurrentRouterPpFee = "9.99",
                    PreviousRouterPpFee = string.Empty,
                    CurrentTransferFee = "FREE",
                    PreviousTransferFee = string.Empty,
                    CurrentNewLineFee = "48.00",
                    PreviousNewLineFee = string.Empty,
                    SavingVsBt = 233,
                    ContractLength = 24}
                },
               {"PhoneLineMax", new TariffDetails() {
                    Id = "PhoneLineMax",
                    TariffId = 10,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    CurrentPricePackage = "FREE",
                    PreviousPricePackage = "6.50",
                    LineRentalFee = 15.45,
                    TotalMonthly = 15.45,
                    CurrentRouterFee = "FREE",
                    PreviousRouterFee = "35.00",
                    CurrentRouterPpFee = "9.99",
                    PreviousRouterPpFee = string.Empty,
                    CurrentTransferFee = "FREE",
                    PreviousTransferFee = string.Empty,
                    CurrentNewLineFee = "48.00",
                    PreviousNewLineFee = string.Empty,
                    SavingVsBt = 233,
                    ContractLength = 24}
                },
            };

            return fakeReturn;
        }

        public static Dictionary<string, TariffFeatures> FakeAllTariffFeaturessReturn()
        {
            var fakeReturn = new Dictionary<string, TariffFeatures>()
            {
                {"PhoneBroadbandBasix", new TariffFeatures()
                    {
                        Id = "PhoneBroadbandBasix",
                        Features = new List<string>()
                        {
                            "For 6 months, £21.95 thereafter",
                            "Free wireless routers &amp; set up",
                            "Unlimited broadband usage",
                            "Free multiple email addresses",
                        }
                    }
                },
                {"PhoneBroadbandMax", new TariffFeatures()
                    {
                        Id = "PhoneBroadbandMax",
                        Features = new List<string>()
                        {
                            "For 6 months, £21.95 thereafter",
                            "Free wireless routers &amp; set up",
                            "Unlimited broadband usage",
                            "Free multiple email addresses",
                        }
                    }
                },
                {"Fibre40Basix", new TariffFeatures()
                    {
                        Id = "Fibre40Basix",
                        Features = new List<string>()
                        {
                            "For 6 months, £21.95 thereafter",
                            "Free wireless routers &amp; set up",
                            "Unlimited broadband usage",
                            "Free multiple email addresses",
                        }
                    }
                },
                {"Fibre40max", new TariffFeatures()
                    {
                        Id = "Fibre40max",
                        Features = new List<string>()
                        {
                            "For 6 months, £21.95 thereafter",
                            "Free wireless routers &amp; set up",
                            "Unlimited broadband usage",
                            "Free multiple email addresses",
                        }
                    }
                },
                {"Fibre80Basix", new TariffFeatures()
                    {
                        Id = "Fibre80Basix",
                        Features = new List<string>()
                        {
                            "For 6 months, £21.95 thereafter",
                            "Free wireless routers &amp; set up",
                            "Unlimited broadband usage",
                            "Free multiple email addresses",
                        }
                    }
                },
                {"Fibre80Max", new TariffFeatures()
                    {
                        Id = "Fibre80Max",
                        Features = new List<string>()
                        {
                            "For 6 months, £21.95 thereafter",
                            "Free wireless routers &amp; set up",
                            "Unlimited broadband usage",
                            "Free multiple email addresses",
                        }
                    }
                },
                {"BroadbandBasix", new TariffFeatures()
                    {
                        Id = "BroadbandBasix",
                        Features = new List<string>()
                        {
                            "For 6 months, £21.95 thereafter",
                            "Free wireless routers &amp; set up",
                            "Unlimited broadband usage",
                            "Free multiple email addresses",
                        }
                    }
                },
                {"BroadbandMax", new TariffFeatures()
                    {
                        Id = "BroadbandMax",
                        Features = new List<string>()
                        {
                            "For 6 months, £21.95 thereafter",
                            "Free wireless routers &amp; set up",
                            "Unlimited broadband usage",
                            "Free multiple email addresses",
                        }
                    }
                },
                {"PhoneLineBasix", new TariffFeatures()
                    {
                        Id = "PhoneLineBasix",
                        Features = new List<string>()
                        {
                            "For 6 months, £21.95 thereafter",
                            "Free wireless routers &amp; set up",
                            "Unlimited broadband usage",
                            "Free multiple email addresses",
                        }
                    }
                },
                {"PhoneLineMax", new TariffFeatures()
                    {
                        Id = "PhoneLineMax",
                        Features = new List<string>()
                        {
                            "For 6 months, £21.95 thereafter",
                            "Free wireless routers &amp; set up",
                            "Unlimited broadband usage",
                            "Free multiple email addresses",
                        }
                    }
                }
            };

            return fakeReturn;
        }

        public static Dictionary<string, BillingDetails> FakeAllBillingDetailsReturn()
        {
            var fakeReturn = new Dictionary<string, BillingDetails>()
            {
                {"PhoneBroadbandBasix", new BillingDetails() {
                    Id = "PhoneBroadbandBasix",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"}
                },
               {"PhoneBroadbandMax", new BillingDetails() {
                    Id = "PhoneBroadbandMax",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"}
                },
               {"Fibre40Basix", new BillingDetails() {
                    Id = "Fibre40Basix",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"}
                },
               {"Fibre40max", new BillingDetails() {
                    Id = "Fibre40max",
                     EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"}
                },
               {"Fibre80Basix", new BillingDetails() {
                    Id = "Fibre80Basix",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"}
                },
               {"Fibre80Max", new BillingDetails() {
                    Id = "Fibre80Max",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"}
                },
               {"BroadbandBasix", new BillingDetails() {
                    Id = "PhoneBroadbandBasix",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"}
                },
               {"BroadbandMax", new BillingDetails() {
                    Id = "BroadbandMax",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"}
                },
               {"PhoneLineBasix", new BillingDetails() {
                    Id = "PhoneLineBasix",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"}
                },
               {"PhoneLineMax", new BillingDetails() {
                    Id = "PhoneLineMax",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"}
                },
            };

            return fakeReturn;
        }
    }
}
