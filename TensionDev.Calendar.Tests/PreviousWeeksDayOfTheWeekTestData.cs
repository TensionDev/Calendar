using System;
using Xunit;

namespace TensionDev.Calendar.Tests
{
    public class PreviousWeeksDayOfTheWeekTestData : TheoryData<DateTime, DayOfWeek, DateTime>
    {
        public PreviousWeeksDayOfTheWeekTestData()
        {
            Add(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Local), DayOfWeek.Sunday, new DateTime(2020, 12, 20, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Local), DayOfWeek.Monday, new DateTime(2020, 12, 21, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Local), DayOfWeek.Tuesday, new DateTime(2020, 12, 22, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Local), DayOfWeek.Wednesday, new DateTime(2020, 12, 23, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Local), DayOfWeek.Thursday, new DateTime(2020, 12, 24, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Local), DayOfWeek.Friday, new DateTime(2020, 12, 25, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 1, 1, 0, 0, 0, DateTimeKind.Local), DayOfWeek.Saturday, new DateTime(2020, 12, 26, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
