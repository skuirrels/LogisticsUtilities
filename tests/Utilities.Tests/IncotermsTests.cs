using Utilities;

namespace Utilities.Tests;

public class IncotermsTests
{
    [Fact]
    public void EXW_Incoterm_ShouldHaveCorrectValues()
    {
        // Arrange
        var expectedId = 1;
        var expectedName = "EXW";
        var expectedDescription = "Ex-Works";
        var expectedTransferOfRisk = "At Buyer's Disposal";
        var expectedChargeResponsibilities = new Dictionary<ChargeCategory, Party>
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
        };

        // Act
        var actualIncoterm = Incoterms.EXW;

        // Assert
        Assert.Equal(expectedId, actualIncoterm.Id);
        Assert.Equal(expectedName, actualIncoterm.Name);
        Assert.Equal(expectedDescription, actualIncoterm.Description);
        Assert.Equal(expectedTransferOfRisk, actualIncoterm.TransferOfRisk);
        foreach (var charge in expectedChargeResponsibilities)
        {
            Assert.True(actualIncoterm.ChargeResponsibilities.ContainsKey(charge.Key));
            Assert.Equal(charge.Value, actualIncoterm.ChargeResponsibilities[charge.Key]);
        }
    }

    [Fact]
    public void FCA_Incoterm_ShouldHaveCorrectValues()
    {
        // Arrange
        var expectedId = 2;
        var expectedName = "FCA";
        var expectedDescription = "Free-Carrier";
        var expectedTransferOfRisk = "On Buyers Transport";
        var expectedChargeResponsibilities = new Dictionary<ChargeCategory, Party>
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
        };

        // Act
        var actualIncoterm = Incoterms.FCA;

        // Assert
        Assert.Equal(expectedId, actualIncoterm.Id);
        Assert.Equal(expectedName, actualIncoterm.Name);
        Assert.Equal(expectedDescription, actualIncoterm.Description);
        Assert.Equal(expectedTransferOfRisk, actualIncoterm.TransferOfRisk);
        foreach (var charge in expectedChargeResponsibilities)
        {
            Assert.True(actualIncoterm.ChargeResponsibilities.ContainsKey(charge.Key));
            Assert.Equal(charge.Value, actualIncoterm.ChargeResponsibilities[charge.Key]);
        }
    }
}