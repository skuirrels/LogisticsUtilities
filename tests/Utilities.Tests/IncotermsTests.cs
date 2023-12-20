// using Utilities;
//
// namespace Utilities.Tests;
//
// public class IncotermsTests
// {
//     [Fact]
//     public void EXW_Incoterm_ShouldHaveCorrectValues()
//     {
//         // Arrange
//         var expectedId = 1;
//         var expectedName = "EXW";
//         var expectedDescription = "Ex-Works";
//         var expectedTransferOfRisk = "At Buyer's Disposal";
//
//         // Act
//         var actualIncoterm = Incoterms.EXW;
//
//         // Assert
//         Assert.Equal(expectedId, actualIncoterm.Id);
//         Assert.Equal(expectedName, actualIncoterm.Name);
//         Assert.Equal(expectedDescription, actualIncoterm.Description);
//         Assert.Equal(expectedTransferOfRisk, actualIncoterm.TransferOfRisk);
//     }
//
//     [Fact]
//     public void FCA_Incoterm_ShouldHaveCorrectValues()
//     {
//         // Arrange
//         var expectedId = 2;
//         var expectedName = "FCA";
//         var expectedDescription = "Free-Carrier";
//         var expectedTransferOfRisk = "On Buyers Transport";
//
//         // Act
//         var actualIncoterm = Incoterms.FCA;
//
//         // Assert
//         Assert.Equal(expectedId, actualIncoterm.Id);
//         Assert.Equal(expectedName, actualIncoterm.Name);
//         Assert.Equal(expectedDescription, actualIncoterm.Description);
//         Assert.Equal(expectedTransferOfRisk, actualIncoterm.TransferOfRisk);
//     }
// }