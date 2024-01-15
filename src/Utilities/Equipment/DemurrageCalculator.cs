namespace Utilities.Demurrage;

public class DemurrageCalculator
{
    public int FullLoadPortFreeTime { get; set; } 

    public class DemurrageResult
    {
        public DateTime AvailableDate { get; init; }
        public DateTime DemurrageStartDate { get; init; }
        public DateTime GateOutDate { get; init; }
        public int DaysOnDemurrage { get; init; }
    }

    public static DemurrageResult CalculateDemurrageDetails(
        DateTime fclUnloaded,
        DateTime actualTimeOfArrival,
        DateTime fclWharfGateOut,
        DateTime actualFullDelivery,
        int fullLoadPortFreeTime) 
    {
        DateTime availableDate = fclUnloaded != DateTime.MinValue ? fclUnloaded 
            : actualTimeOfArrival != DateTime.MinValue ? actualTimeOfArrival 
            : DateTime.MinValue;

        DateTime demurrageStartDate = availableDate != DateTime.MinValue ? availableDate.AddDays(fullLoadPortFreeTime) 
            : DateTime.MinValue;

        DateTime gateOutDate = fclWharfGateOut != DateTime.MinValue ? fclWharfGateOut 
            : actualFullDelivery != DateTime.MinValue ? actualFullDelivery 
            : DateTime.Now;

        TimeSpan demurrageTimeSpan = gateOutDate - demurrageStartDate;
        
        int daysOnDemurrage = Math.Max(0, demurrageTimeSpan.Days);

        return new DemurrageResult
        {
            AvailableDate = availableDate,
            DemurrageStartDate = demurrageStartDate,
            GateOutDate = gateOutDate,
            DaysOnDemurrage = daysOnDemurrage
        };
    }
}