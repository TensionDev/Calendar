using System;
using Xunit;

namespace TensionDev.Calendar.Tests
{
    public class NextWeeksDayOfTheWeekTestData : TheoryData<DateTime, DayOfWeek, DateTime>
    {
        public NextWeeksDayOfTheWeekTestData()
        {
            Add(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Local), DayOfWeek.Sunday, new DateTime(2021, 1, 3, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Local), DayOfWeek.Monday, new DateTime(2021, 1, 4, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Local), DayOfWeek.Tuesday, new DateTime(2021, 1, 5, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Local), DayOfWeek.Wednesday, new DateTime(2021, 1, 6, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Local), DayOfWeek.Thursday, new DateTime(2021, 1, 7, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Local), DayOfWeek.Friday, new DateTime(2021, 1, 8, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Local), DayOfWeek.Saturday, new DateTime(2021, 1, 9, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
