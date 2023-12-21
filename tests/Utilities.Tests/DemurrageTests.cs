using Utilities.Demurrage;

namespace Utilities.Tests
{
    public class DemurrageCalculatorTests
    {
        [Fact]
        public void CalculateDemurrageDetails_ShouldCalculateCorrectly()
        {
            // Arrange
            DateTime fclUnloaded = DateTime.Now.AddDays(-10);
            DateTime actualTimeOfArrival = DateTime.Now.AddDays(-9);
            DateTime fclWharfGateOut = DateTime.Now.AddDays(-5);
            DateTime actualFullDelivery = DateTime.Now.AddDays(-4);
            int fullLoadPortFreeTime = 2;

            // Act
            var result = DemurrageCalculator.CalculateDemurrageDetails(
                fclUnloaded,
                actualTimeOfArrival,
                fclWharfGateOut,
                actualFullDelivery,
                fullLoadPortFreeTime);

            // Assert
            Assert.Equal(fclUnloaded, result.AvailableDate);
            Assert.Equal(fclUnloaded.AddDays(fullLoadPortFreeTime), result.DemurrageStartDate);
            Assert.Equal(fclWharfGateOut, result.GateOutDate);
            Assert.Equal((fclWharfGateOut - fclUnloaded.AddDays(fullLoadPortFreeTime)).Days, result.DaysOnDemurrage);
        }
    }
}