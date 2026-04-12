using System;
using Xunit;

namespace TensionDev.Calendar.Tests
{
    public class LastDayOfTheMonthTestData : TheoryData<DateTime, DateTime>
    {
        public LastDayOfTheMonthTestData()
        {
            Add(new DateTime(2021, 1, 15, 12, 0, 0, DateTimeKind.Local), new DateTime(2021, 1, 31, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 2, 28, 23, 59, 59, DateTimeKind.Local), new DateTime(2021, 2, 28, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 3, 17, 23, 59, 59, DateTimeKind.Local), new DateTime(2021, 3, 31, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 4, 13, 23, 59, 59, DateTimeKind.Local), new DateTime(2021, 4, 30, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 5, 11, 23, 59, 59, DateTimeKind.Local), new DateTime(2021, 5, 31, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 6, 23, 23, 59, 59, DateTimeKind.Local), new DateTime(2021, 6, 30, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 7, 29, 23, 59, 59, DateTimeKind.Local), new DateTime(2021, 7, 31, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 8, 7, 23, 59, 59, DateTimeKind.Local), new DateTime(2021, 8, 31, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 9, 5, 23, 59, 59, DateTimeKind.Local), new DateTime(2021, 9, 30, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 10, 3, 23, 59, 59, DateTimeKind.Local), new DateTime(2021, 10, 31, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 11, 1, 23, 59, 59, DateTimeKind.Local), new DateTime(2021, 11, 30, 0, 0, 0, DateTimeKind.Local));
            Add(new DateTime(2021, 12, 31, 23, 59, 59, DateTimeKind.Local), new DateTime(2021, 12, 31, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
