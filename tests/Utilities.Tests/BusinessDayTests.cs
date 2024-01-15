using System;
using System.Collections.Generic;
using Xunit;

using Utilities;

namespace Utilities.Tests
{
    public class BusinessDayTests
    {
        readonly DateTime _startDate = new DateTime(2023, 2, 2);
        readonly DateTime _endDate = new DateTime(2023, 2, 23);
        
        [Fact]
        public void TestDefaultGetBusinessDays()
        {
            // Call the method without weekendDays
            var defaultWeekdays = BusinessDays.GetBusinessDays(_startDate, _endDate);
            Assert.Equal(15, defaultWeekdays);
            
        }

        [Fact]
        public void TestIsraeliWeekDays()
        {
            // Call the method with weekendDays for Israel (Fri, Sat) as a List
            var israeliWeekDays = BusinessDays.GetBusinessDays(_startDate, _endDate, 5);
            Assert.Equal(15, israeliWeekDays);
        }
    }
}

