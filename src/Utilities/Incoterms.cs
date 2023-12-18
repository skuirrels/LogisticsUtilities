namespace Utilities
{
    public enum ChargeCategory
    {
        ExportPackaging = 1,
        MarkingAndLabelling = 2,
        LoadingCharges = 3,
        DeliveryToPortPlace = 4,
        ExportClearance = 5,
        FreightForwarderDocumentationFees = 6,
        LoadingOnCarriage = 7,
        OriginTerminalCharges = 8,
        Freight = 9,
        Insurance = 10,
        DestinationTerminalCharges = 11,
        ImportDutiesTaxes = 12,
        CustomsBrokerClearanceFees = 13,
        DeliveryToDestination = 14,
        DeliveryCarrierUnloading = 15,
        SecurityInformationRequirements = 16
    }

    public enum Party
    {
        Buyer = 1,
        Supplier = 2
    }

    public record Incoterm(
        int Id, 
        string Name, 
        string Description, 
        string TransferOfRisk, 
        Dictionary<ChargeCategory, Party> ChargeResponsibilities);

    public static class Incoterms
    {
        public static readonly Incoterm EXW = new(1, "EXW", "Ex-Works", @"At Buyer's Disposal", new Dictionary<ChargeCategory, Party>
        {
            { ChargeCategory.ExportPackaging, Party.Supplier },
            { ChargeCategory.MarkingAndLabelling, Party.Supplier },
            { ChargeCategory.LoadingCharges, Party.Buyer },
            { ChargeCategory.DeliveryToPortPlace, Party.Buyer },
            { ChargeCategory.ExportClearance, Party.Buyer },
            { ChargeCategory.FreightForwarderDocumentationFees, Party.Buyer },
            { ChargeCategory.LoadingOnCarriage, Party.Buyer },
            { ChargeCategory.OriginTerminalCharges, Party.Buyer },
            { ChargeCategory.Freight, Party.Buyer },
            { ChargeCategory.Insurance, Party.Buyer },
            { ChargeCategory.DestinationTerminalCharges, Party.Buyer },
            { ChargeCategory.ImportDutiesTaxes, Party.Buyer },
            { ChargeCategory.CustomsBrokerClearanceFees, Party.Buyer },
            { ChargeCategory.DeliveryToDestination, Party.Buyer },
            { ChargeCategory.DeliveryCarrierUnloading, Party.Buyer },
            { ChargeCategory.SecurityInformationRequirements, Party.Buyer }
        });
        public static readonly Incoterm FCA = new(2, "FCA", "Free-Carrier", "On Buyers Transport",new Dictionary<ChargeCategory, Party>
        {
            { ChargeCategory.ExportPackaging, Party.Supplier },
            { ChargeCategory.MarkingAndLabelling, Party.Supplier },
            { ChargeCategory.LoadingCharges, Party.Supplier },
            { ChargeCategory.DeliveryToPortPlace, Party.Supplier },
            { ChargeCategory.ExportClearance, Party.Supplier },
            { ChargeCategory.FreightForwarderDocumentationFees, Party.Buyer },
            { ChargeCategory.LoadingOnCarriage, Party.Buyer },
            { ChargeCategory.OriginTerminalCharges, Party.Buyer },
            { ChargeCategory.Freight, Party.Buyer },
            { ChargeCategory.Insurance, Party.Buyer },
            { ChargeCategory.DestinationTerminalCharges, Party.Buyer },
            { ChargeCategory.ImportDutiesTaxes, Party.Buyer },
            { ChargeCategory.CustomsBrokerClearanceFees, Party.Buyer },
            { ChargeCategory.DeliveryToDestination, Party.Buyer },
            { ChargeCategory.DeliveryCarrierUnloading, Party.Buyer },
            { ChargeCategory.SecurityInformationRequirements, Party.Buyer }
        });
        public static readonly Incoterm FAS = new(3, "FAS", "Free Along-Side Ship", "Alongside Ship", new Dictionary<ChargeCategory, Party>
        {
            { ChargeCategory.ExportPackaging, Party.Supplier },
            { ChargeCategory.MarkingAndLabelling, Party.Supplier },
            { ChargeCategory.LoadingCharges, Party.Supplier },
            { ChargeCategory.DeliveryToPortPlace, Party.Supplier },
            { ChargeCategory.ExportClearance, Party.Supplier },
            { ChargeCategory.FreightForwarderDocumentationFees, Party.Buyer },
            { ChargeCategory.LoadingOnCarriage, Party.Buyer },
            { ChargeCategory.OriginTerminalCharges, Party.Buyer },
            { ChargeCategory.Freight, Party.Buyer },
            { ChargeCategory.Insurance, Party.Buyer },
            { ChargeCategory.DestinationTerminalCharges, Party.Buyer },
            { ChargeCategory.ImportDutiesTaxes, Party.Buyer },
            { ChargeCategory.CustomsBrokerClearanceFees, Party.Buyer },
            { ChargeCategory.DeliveryToDestination, Party.Buyer },
            { ChargeCategory.DeliveryCarrierUnloading, Party.Buyer },
            { ChargeCategory.SecurityInformationRequirements, Party.Buyer }
        });
        public static readonly Incoterm FOB = new(4, "FOB", "Free On Board","On Board Vessel", new Dictionary<ChargeCategory, Party>
        {
            { ChargeCategory.ExportPackaging, Party.Supplier },
            { ChargeCategory.MarkingAndLabelling, Party.Supplier },
            { ChargeCategory.LoadingCharges, Party.Supplier },
            { ChargeCategory.DeliveryToPortPlace, Party.Supplier },
            { ChargeCategory.ExportClearance, Party.Supplier },
            { ChargeCategory.FreightForwarderDocumentationFees, Party.Supplier },
            { ChargeCategory.LoadingOnCarriage, Party.Supplier },
            { ChargeCategory.OriginTerminalCharges, Party.Supplier },
            { ChargeCategory.Freight, Party.Buyer },
            { ChargeCategory.Insurance, Party.Buyer },
            { ChargeCategory.DestinationTerminalCharges, Party.Buyer },
            { ChargeCategory.ImportDutiesTaxes, Party.Buyer },
            { ChargeCategory.CustomsBrokerClearanceFees, Party.Buyer },
            { ChargeCategory.DeliveryToDestination, Party.Buyer },
            { ChargeCategory.DeliveryCarrierUnloading, Party.Buyer },
            { ChargeCategory.SecurityInformationRequirements, Party.Buyer }
        });
        public static readonly Incoterm CFR = new(5, "CFR", "Cost and Freight", "On Board Vessel", new Dictionary<ChargeCategory, Party>
        {
            { ChargeCategory.ExportPackaging, Party.Supplier },
            { ChargeCategory.MarkingAndLabelling, Party.Supplier },
            { ChargeCategory.LoadingCharges, Party.Supplier },
            { ChargeCategory.DeliveryToPortPlace, Party.Supplier },
            { ChargeCategory.ExportClearance, Party.Supplier },
            { ChargeCategory.FreightForwarderDocumentationFees, Party.Supplier },
            { ChargeCategory.LoadingOnCarriage, Party.Supplier },
            { ChargeCategory.OriginTerminalCharges, Party.Supplier },
            { ChargeCategory.Freight, Party.Supplier },
            { ChargeCategory.Insurance, Party.Buyer },
            { ChargeCategory.DestinationTerminalCharges, Party.Buyer },
            { ChargeCategory.ImportDutiesTaxes, Party.Buyer },
            { ChargeCategory.CustomsBrokerClearanceFees, Party.Buyer },
            { ChargeCategory.DeliveryToDestination, Party.Buyer },
            { ChargeCategory.DeliveryCarrierUnloading, Party.Buyer },
            { ChargeCategory.SecurityInformationRequirements, Party.Buyer }
        });
        public static readonly Incoterm CIF = new(6, "CIF", "Cost Insurance and Freight", "On Board Vessel", new Dictionary<ChargeCategory, Party>
        {
            { ChargeCategory.ExportPackaging, Party.Supplier },
            { ChargeCategory.MarkingAndLabelling, Party.Supplier },
            { ChargeCategory.LoadingCharges, Party.Supplier },
            { ChargeCategory.DeliveryToPortPlace, Party.Supplier },
            { ChargeCategory.ExportClearance, Party.Supplier },
            { ChargeCategory.FreightForwarderDocumentationFees, Party.Supplier },
            { ChargeCategory.LoadingOnCarriage, Party.Supplier },
            { ChargeCategory.OriginTerminalCharges, Party.Supplier },
            { ChargeCategory.Freight, Party.Supplier },
            { ChargeCategory.Insurance, Party.Supplier },
            { ChargeCategory.DestinationTerminalCharges, Party.Buyer },
            { ChargeCategory.ImportDutiesTaxes, Party.Buyer },
            { ChargeCategory.CustomsBrokerClearanceFees, Party.Buyer },
            { ChargeCategory.DeliveryToDestination, Party.Buyer },
            { ChargeCategory.DeliveryCarrierUnloading, Party.Buyer },
            { ChargeCategory.SecurityInformationRequirements, Party.Buyer }
        });
        public static readonly Incoterm CPT = new(7, "CPT", "Carriage Paid To","At Carrier",new Dictionary<ChargeCategory, Party>
        {
            { ChargeCategory.ExportPackaging, Party.Supplier },
            { ChargeCategory.MarkingAndLabelling, Party.Supplier },
            { ChargeCategory.LoadingCharges, Party.Supplier },
            { ChargeCategory.DeliveryToPortPlace, Party.Supplier },
            { ChargeCategory.ExportClearance, Party.Supplier },
            { ChargeCategory.FreightForwarderDocumentationFees, Party.Supplier },
            { ChargeCategory.LoadingOnCarriage, Party.Supplier },
            { ChargeCategory.OriginTerminalCharges, Party.Supplier },
            { ChargeCategory.Freight, Party.Supplier },
            { ChargeCategory.Insurance, Party.Supplier },
            { ChargeCategory.DestinationTerminalCharges, Party.Supplier },
            { ChargeCategory.ImportDutiesTaxes, Party.Buyer },
            { ChargeCategory.CustomsBrokerClearanceFees, Party.Buyer },
            { ChargeCategory.DeliveryToDestination, Party.Buyer },
            { ChargeCategory.DeliveryCarrierUnloading, Party.Buyer },
            { ChargeCategory.SecurityInformationRequirements, Party.Buyer }
        });
        public static readonly Incoterm CIP = new(8, "CIP", "Carriage Insurance Paid To", "At Carrier",new Dictionary<ChargeCategory, Party>
        {
            { ChargeCategory.ExportPackaging, Party.Supplier },
            { ChargeCategory.MarkingAndLabelling, Party.Supplier },
            { ChargeCategory.LoadingCharges, Party.Supplier },
            { ChargeCategory.DeliveryToPortPlace, Party.Supplier },
            { ChargeCategory.ExportClearance, Party.Supplier },
            { ChargeCategory.FreightForwarderDocumentationFees, Party.Supplier },
            { ChargeCategory.LoadingOnCarriage, Party.Supplier },
            { ChargeCategory.OriginTerminalCharges, Party.Supplier },
            { ChargeCategory.Freight, Party.Supplier },
            { ChargeCategory.Insurance, Party.Supplier },
            { ChargeCategory.DestinationTerminalCharges, Party.Supplier },
            { ChargeCategory.ImportDutiesTaxes, Party.Buyer },
            { ChargeCategory.CustomsBrokerClearanceFees, Party.Buyer },
            { ChargeCategory.DeliveryToDestination, Party.Supplier },
            { ChargeCategory.DeliveryCarrierUnloading, Party.Buyer },
            { ChargeCategory.SecurityInformationRequirements, Party.Buyer }
        });
        
        public static readonly Incoterm DAP = new(14, "DAP", "Delivered at Place", "At Named Place",new Dictionary<ChargeCategory, Party>
        {
            { ChargeCategory.ExportPackaging, Party.Supplier },
            { ChargeCategory.MarkingAndLabelling, Party.Supplier },
            { ChargeCategory.LoadingCharges, Party.Supplier },
            { ChargeCategory.DeliveryToPortPlace, Party.Supplier },
            { ChargeCategory.ExportClearance, Party.Supplier },
            { ChargeCategory.FreightForwarderDocumentationFees, Party.Supplier },
            { ChargeCategory.LoadingOnCarriage, Party.Supplier },
            { ChargeCategory.OriginTerminalCharges, Party.Supplier },
            { ChargeCategory.Freight, Party.Supplier },
            { ChargeCategory.Insurance, Party.Supplier },
            { ChargeCategory.DestinationTerminalCharges, Party.Supplier },
            { ChargeCategory.ImportDutiesTaxes, Party.Buyer },
            { ChargeCategory.CustomsBrokerClearanceFees, Party.Buyer },
            { ChargeCategory.DeliveryToDestination, Party.Supplier },
            { ChargeCategory.DeliveryCarrierUnloading, Party.Supplier },
            { ChargeCategory.SecurityInformationRequirements, Party.Buyer }
        });
        
        public static readonly Incoterm DPU = new(12, "DPU", "Delivered at Place Unloaded", "At Named Place Unloaded",new Dictionary<ChargeCategory, Party>
        {
            { ChargeCategory.ExportPackaging, Party.Supplier },
            { ChargeCategory.MarkingAndLabelling, Party.Supplier },
            { ChargeCategory.LoadingCharges, Party.Supplier },
            { ChargeCategory.DeliveryToPortPlace, Party.Supplier },
            { ChargeCategory.ExportClearance, Party.Supplier },
            { ChargeCategory.FreightForwarderDocumentationFees, Party.Supplier },
            { ChargeCategory.LoadingOnCarriage, Party.Supplier },
            { ChargeCategory.OriginTerminalCharges, Party.Supplier },
            { ChargeCategory.Freight, Party.Supplier },
            { ChargeCategory.Insurance, Party.Supplier },
            { ChargeCategory.DestinationTerminalCharges, Party.Supplier },
            { ChargeCategory.ImportDutiesTaxes, Party.Buyer },
            { ChargeCategory.CustomsBrokerClearanceFees, Party.Buyer },
            { ChargeCategory.DeliveryToDestination, Party.Supplier },
            { ChargeCategory.DeliveryCarrierUnloading, Party.Buyer },
            { ChargeCategory.SecurityInformationRequirements, Party.Buyer }
        });
        public static readonly Incoterm DDP = new(13, "DDP", "Delivery Duty Paid", "At Named Place", new Dictionary<ChargeCategory, Party>
        {
            { ChargeCategory.ExportPackaging, Party.Supplier },
            { ChargeCategory.MarkingAndLabelling, Party.Supplier },
            { ChargeCategory.LoadingCharges, Party.Supplier },
            { ChargeCategory.DeliveryToPortPlace, Party.Supplier },
            { ChargeCategory.ExportClearance, Party.Supplier },
            { ChargeCategory.FreightForwarderDocumentationFees, Party.Supplier },
            { ChargeCategory.LoadingOnCarriage, Party.Supplier },
            { ChargeCategory.OriginTerminalCharges, Party.Supplier },
            { ChargeCategory.Freight, Party.Supplier },
            { ChargeCategory.Insurance, Party.Supplier },
            { ChargeCategory.DestinationTerminalCharges, Party.Supplier },
            { ChargeCategory.ImportDutiesTaxes, Party.Supplier },
            { ChargeCategory.CustomsBrokerClearanceFees, Party.Supplier },
            { ChargeCategory.DeliveryToDestination, Party.Supplier },
            { ChargeCategory.DeliveryCarrierUnloading, Party.Buyer },
            { ChargeCategory.SecurityInformationRequirements, Party.Buyer }
        });
    }
}