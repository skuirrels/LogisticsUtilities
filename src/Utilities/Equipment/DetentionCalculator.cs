namespace Utilities.Equipment;

public class DetentionCalculator
{
    public int DetentionFreeTime { get; set; }

    public class DetentionResult
    {
        public DateTime GateOut { get; init; }

        public DateTime EmptyReturnedOn { get; init; }

        public DateTime DetentionStartDate { get; init; }

        public int DaysOnDetention { get; init; }
    }
    
    public static DetentionResult CalculateDetentionDetails(
        DateTime fclWharfGateOut,
        DateTime emptyReturnedOn,
        int detentionFreeTime)
    {
        var detentionTimeSpan = emptyReturnedOn - fclWharfGateOut;
        
        var detentionStartDate = fclWharfGateOut.AddDays(detentionFreeTime).AddDays(1);
        
        var daysOnDetentionAfterFreeTime = Math.Max(0, detentionTimeSpan.Days - detentionFreeTime);

        return new DetentionResult
        {
            GateOut = fclWharfGateOut,
            EmptyReturnedOn = emptyReturnedOn,
            DetentionStartDate = detentionStartDate,
            DaysOnDetention = daysOnDetentionAfterFreeTime
        };
    }
}