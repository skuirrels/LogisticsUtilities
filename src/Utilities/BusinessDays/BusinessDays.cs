namespace Utilities;

public class BusinessDays
{
    public static int GetBusinessDays(DateTime startDate, DateTime endDate, int? weekendStartDay = 6)
    {
        // Calculate the weekend days based on the weekendStartDay
        // Assumes Saturday is 6 and Sunday is 0
        DayOfWeek[] weekendDays =
        {
            (DayOfWeek) (weekendStartDay % 7)!,
            (DayOfWeek) ((weekendStartDay + 1) % 7)!
        };
 
        // Initialise the count of business days to 0
        int businessDays = 0;
   
        // Loop through each day between the start date and end date
        for (DateTime date = startDate.AddDays(1); date <= endDate; date = date.AddDays(1))
        {
            // Check if the current day is a weekday and not a weekend day - only incrementing the weekdays
            if (!weekendDays.Contains(date.DayOfWeek))
            {
                businessDays++;
            }
        }
        return businessDays;
    }    
}

