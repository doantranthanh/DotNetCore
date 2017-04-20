using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Core.Signup.Entities.POCO.BillingDetails;
using Core.Signup.Entities.POCO.Tariff;

namespace Demo451
{
    public class FakeXmlFiles
    {
        public static XDocument MappingXmlFile()
        {

            var mappingElements = new List<FakeXmlMapping>()
            {
                new FakeXmlMapping { Id = "PhoneBroadbandBasix", Identifier = new List<string>() {"cc", "cc_affl"} },
                new FakeXmlMapping { Id = "PhoneBroadbandMax", Identifier = new List<string>() { "ccmax_affl" } },
                new FakeXmlMapping { Id = "Fibre40Basix", Identifier = new List<string>() { "basix_40_affl" } },
                new FakeXmlMapping { Id = "Fibre40max", Identifier = new List<string>() { "max_40_affl" } },
                new FakeXmlMapping { Id = "Fibre80Basix", Identifier = new List<string>() { "basix_80_affl" } },
                new FakeXmlMapping { Id = "Fibre80Max", Identifier =  new List<string>(){ "max_80_affl" } },
                new FakeXmlMapping { Id = "BroadbandBasix", Identifier = new List<string>() { "bb" } },
                new FakeXmlMapping { Id = "BroadbandMax", Identifier = new List<string>() { "bbmax" } },
                new FakeXmlMapping { Id = "PhoneLineBasix", Identifier = new List<string>() { "tt" } },
                new FakeXmlMapping { Id = "PhoneLineMax", Identifier = new List<string>() { "ttmax" } }
            };

            var doc = new XDocument
            (
                new XElement
                (
                    "mappings",
                    mappingElements.Select
                    (
                        m => new XElement
                        (
                            "mapping",
                            new XAttribute("id", m.Id),
                            new XElement("identifiers",
                                m.Identifier.Select
                                (
                                    i => new XElement
                                    (
                                        "identifier", i.ToString()
                                    )
                                )
                            )
                        )

                    )
                )
            );

            return doc;
        }


        public static XDocument TariffDetailsXmlFile()
        {
            var tarriffDetailsElements = new List<TariffDetails>
            {
                new TariffDetails
                {
                    Id = "PhoneBroadbandBasix",
                    TariffId = 1,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    ProductType = 1,
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
                    ContractLength = 24
                },
                new TariffDetails
                {
                    Id = "PhoneBroadbandMax",
                    TariffId = 2,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    ProductType = 1,
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
                    ContractLength = 24
                },
                new TariffDetails
                {
                    Id = "Fibre40Basix",
                    TariffId = 3,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    ProductType = 1,
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
                    ContractLength = 24
                },
                new TariffDetails
                {
                    Id = "Fibre40max",
                    TariffId = 4,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    ProductType = 1,
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
                    ContractLength = 24
                },
                new TariffDetails
                {
                    Id = "Fibre80Basix",
                    TariffId = 5,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    ProductType = 1,
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
                    ContractLength = 24
                },
                new TariffDetails
                {
                    Id = "Fibre80Max",
                    TariffId = 6,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    ProductType = 1,
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
                    ContractLength = 24
                },
                new TariffDetails
                {
                    Id = "BroadbandBasix",
                    TariffId = 7,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    ProductType = 1,
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
                    ContractLength = 24
                },
                new TariffDetails
                {
                    Id = "BroadbandMax",
                    TariffId = 8,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    ProductType = 1,
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
                    ContractLength = 24
                },
                new TariffDetails
                {
                    Id = "PhoneLineBasix",
                    TariffId = 9,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    ProductType = 1,
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
                    ContractLength = 24
                },
                new TariffDetails
                {
                    Id = "PhoneLineMax",
                    TariffId = 10,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    ProductType = 1,
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
                    ContractLength = 24
                },
                 new TariffDetails
                {
                    Id = "ProductExceptions",
                    TariffId = 11,
                    TariffPlanId = 2624,
                    TariffPlanTransferId = 2624,
                    ProductChosen = "Connect Basix",
                    ProductType = 1,
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
                    ContractLength = 24
                },
            };

            var doc = new XDocument
            (
                new XElement
                (
                    "tariffDetails",
                    tarriffDetailsElements.Select
                    (
                        m => new XElement
                        (
                            "tariffDetail",
                            new XAttribute("id", m.Id),
                            new XElement("tariffId", m.TariffId),
                            new XElement("tariffPlanId", m.TariffPlanId),
                            new XElement("tariffPlanTransferId", m.TariffPlanTransferId),
                            new XElement("productChosen", m.ProductChosen),
                            new XElement("productType", m.ProductType),
                            new XElement("currentPricePackage", m.CurrentPricePackage),
                            new XElement("previousPricePackage", m.PreviousPricePackage),
                            new XElement("lineRentalFee", m.LineRentalFee),
                            new XElement("totalMonthly", m.TotalMonthly),
                            new XElement("currentRouterFee", m.CurrentRouterFee),
                            new XElement("previousRouterFee", m.PreviousRouterFee),
                            new XElement("currentRouterPpFee", m.CurrentRouterPpFee),
                            new XElement("previousRouterPpFee", m.PreviousRouterPpFee),
                            new XElement("currentTransferFee", m.CurrentTransferFee),
                            new XElement("previousTransferFee", m.PreviousTransferFee),
                            new XElement("currentNewLineFee", m.CurrentNewLineFee),
                            new XElement("previousNewLineFee", m.PreviousNewLineFee),
                            new XElement("savingVsBt", m.SavingVsBt),
                            new XElement("contractLength", m.ContractLength)
                        )
                    )
                )
            );

            return doc;
        }

        public static XDocument TariffFeaturesXmlFile()
        {
            var tarriffFeaturesElements = new List<TariffFeatures>
            {
                new TariffFeatures
                {
                    Id = "PhoneBroadbandBasix",
                    Features = new List<string>()
                    {
                        "For 6 months, £21.95 thereafter",
                        "Free wireless routers &amp; set up",
                        "Unlimited broadband usage",
                        "Free multiple email addresses",
                    }
                },
                new TariffFeatures
                {
                    Id = "PhoneBroadbandMax",
                    Features = new List<string>()
                    {
                        "For 6 months, £21.95 thereafter",
                        "Free wireless routers &amp; set up",
                        "Unlimited broadband usage",
                        "Free multiple email addresses",
                    }
                },
                new TariffFeatures
                {
                    Id = "Fibre40Basix",
                    Features = new List<string>()
                    {
                        "For 6 months, £21.95 thereafter",
                        "Free wireless routers &amp; set up",
                        "Unlimited broadband usage",
                        "Free multiple email addresses",
                    }
                },
                new TariffFeatures
                {
                    Id = "Fibre40max",
                    Features = new List<string>()
                    {
                        "For 6 months, £21.95 thereafter",
                        "Free wireless routers &amp; set up",
                        "Unlimited broadband usage",
                        "Free multiple email addresses",
                    }
                },
                new TariffFeatures
                {
                    Id = "Fibre80Basix",
                    Features = new List<string>()
                    {
                        "For 6 months, £21.95 thereafter",
                        "Free wireless routers &amp; set up",
                        "Unlimited broadband usage",
                        "Free multiple email addresses",
                    }
                },
                new TariffFeatures
                {
                    Id = "Fibre80Max",
                    Features = new List<string>()
                    {
                        "For 6 months, £21.95 thereafter",
                        "Free wireless routers &amp; set up",
                        "Unlimited broadband usage",
                        "Free multiple email addresses",
                    }
                },
                new TariffFeatures
                {
                    Id = "BroadbandBasix",
                    Features = new List<string>()
                    {
                        "For 6 months, £21.95 thereafter",
                        "Free wireless routers &amp; set up",
                        "Unlimited broadband usage",
                        "Free multiple email addresses",
                    }
                },
                new TariffFeatures
                {
                    Id = "BroadbandMax",
                    Features = new List<string>()
                    {
                        "For 6 months, £21.95 thereafter",
                        "Free wireless routers &amp; set up",
                        "Unlimited broadband usage",
                        "Free multiple email addresses",
                    }
                },
                new TariffFeatures
                {
                    Id = "PhoneLineBasix",
                    Features = new List<string>()
                    {
                        "For 6 months, £21.95 thereafter",
                        "Free wireless routers &amp; set up",
                        "Unlimited broadband usage",
                        "Free multiple email addresses",
                    }
                },
                new TariffFeatures
                {
                    Id = "PhoneLineMax",
                    Features = new List<string>()
                    {
                        "For 6 months, £21.95 thereafter",
                        "Free wireless routers &amp; set up",
                        "Unlimited broadband usage",
                        "Free multiple email addresses",
                    }
                },
            };

            var doc = new XDocument
            (
                new XElement
                (
                    "tariffFeatures",
                    tarriffFeaturesElements.Select
                    (
                        m => new XElement
                        (
                            "tariffFeature",
                            new XAttribute("id", m.Id),
                            new XElement
                            (
                                "features",
                                m.Features.Select
                                (
                                    f => new XElement
                                    (
                                        "feature", f.ToString()
                                    )
                                )
                            )
                        )
                    )
                )
            );

            return doc;
        }

        public static XDocument BillingDetailsXmlFile()
        {
            var billingDetailsElements = new List<BillingDetails>
            {
                new BillingDetails
                {
                    Id = "PhoneBroadbandBasix",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"
                },
                new BillingDetails
                {
                    Id = "PhoneBroadbandMax",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"
                },
                new BillingDetails
                {
                    Id = "Fibre40Basix",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"
                },
                new BillingDetails
                {
                    Id = "Fibre40max",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"
                },
                new BillingDetails
                {
                    Id = "Fibre80Basix",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"
                },
                new BillingDetails
                {
                    Id = "Fibre80Max",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"
                },
                new BillingDetails
                {
                    Id = "BroadbandBasix",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"
                },
                new BillingDetails
                {
                    Id = "BroadbandMax",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"
                },
                new BillingDetails
                {
                    Id = "PhoneLineBasix",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"
                },
                new BillingDetails
                {
                    Id = "PhoneLineMax",
                    EbillingCharge = "No Charge",
                    PaperCharge = "2.00",
                    DirectDebitCharge = "No Charge",
                    ManualPayCharge = "3.95"
                },
            };

            var doc = new XDocument
            (
                new XElement
                (
                    "bilingDetails",
                    billingDetailsElements.Select
                    (
                        m => new XElement
                        (
                            "bilingDetail",
                            new XAttribute("id", m.Id),
                            new XElement("ebillingCharge", m.EbillingCharge),
                            new XElement("paperCharge", m.PaperCharge),
                            new XElement("directDebitCharge", m.DirectDebitCharge),
                            new XElement("manualPayCharge", m.ManualPayCharge)                         
                        )
                    )
                )
            );

            return doc;
        }
    }
}
