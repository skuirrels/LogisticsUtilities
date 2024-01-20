using System;
using Xunit;
using Utilities;
using Utilities.Equipment;

namespace Utilities.Tests
{
    public class DetentionCalculatorTests
    {
        [Theory]
        [InlineData("2021-10-01", "2021-10-02", 2, 0)]
        [InlineData("2021-10-01", "2021-10-02", 1, 0)]
        [InlineData("2021-10-01", "2021-10-02", 0, 1)]
        [InlineData("2021-10-01", "2021-10-05", 2, 2)]
        [InlineData("2021-10-01", "2021-10-01", 1, 0)]
        public void TestCalculateDetention(
            string fclWharfGateOut,
            string emptyReturnedOn,
            int detentionFreeTime,
            int expectedDaysOnDetention)
        {
            // Arrange
            DateTime fclWharfGateOutDate = DateTime.Parse(fclWharfGateOut);
            DateTime emptyReturnedOnDate = DateTime.Parse(emptyReturnedOn);
            
            // Act
            var result = DetentionCalculator.CalculateDetentionDetails(
                fclWharfGateOutDate,
                emptyReturnedOnDate,
                detentionFreeTime);
            
            // Assert
            Assert.Equal(expectedDaysOnDetention, result.DaysOnDetention);
        }
    }
}