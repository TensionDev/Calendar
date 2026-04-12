using System;
using Xunit;

namespace TensionDev.Calendar.Tests
{
    public class DayOfTheMonthTestData : TheoryData<int, int, Gregorian.WeekOfTheMonth, DayOfWeek, DateTime>
    {
        public DayOfTheMonthTestData()
        {
            January1970();
            December1970();
            February1998();
            November1998();
        }

        private void January1970()
        {
            Add(1970, 1, Gregorian.WeekOfTheMonth.First, DayOfWeek.Sunday, new DateTime(1970, 1, 4, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.First, DayOfWeek.Monday, new DateTime(1970, 1, 5, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.First, DayOfWeek.Tuesday, new DateTime(1970, 1, 6, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.First, DayOfWeek.Wednesday, new DateTime(1970, 1, 7, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.First, DayOfWeek.Thursday, new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.First, DayOfWeek.Friday, new DateTime(1970, 1, 2, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.First, DayOfWeek.Saturday, new DateTime(1970, 1, 3, 0, 0, 0, DateTimeKind.Local));

            Add(1970, 1, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Sunday, new DateTime(1970, 1, 11, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Monday, new DateTime(1970, 1, 12, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Tuesday, new DateTime(1970, 1, 13, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Wednesday, new DateTime(1970, 1, 14, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Thursday, new DateTime(1970, 1, 8, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Friday, new DateTime(1970, 1, 9, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Saturday, new DateTime(1970, 1, 10, 0, 0, 0, DateTimeKind.Local));

            Add(1970, 1, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Sunday, new DateTime(1970, 1, 18, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Monday, new DateTime(1970, 1, 19, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Tuesday, new DateTime(1970, 1, 20, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Wednesday, new DateTime(1970, 1, 21, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Thursday, new DateTime(1970, 1, 15, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Friday, new DateTime(1970, 1, 16, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Saturday, new DateTime(1970, 1, 17, 0, 0, 0, DateTimeKind.Local));

            Add(1970, 1, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Sunday, new DateTime(1970, 1, 25, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Monday, new DateTime(1970, 1, 26, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Tuesday, new DateTime(1970, 1, 27, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Wednesday, new DateTime(1970, 1, 28, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Thursday, new DateTime(1970, 1, 22, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Friday, new DateTime(1970, 1, 23, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Saturday, new DateTime(1970, 1, 24, 0, 0, 0, DateTimeKind.Local));

            Add(1970, 1, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Sunday, new DateTime(1970, 1, 25, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Monday, new DateTime(1970, 1, 26, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Tuesday, new DateTime(1970, 1, 27, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Wednesday, new DateTime(1970, 1, 28, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Thursday, new DateTime(1970, 1, 29, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Friday, new DateTime(1970, 1, 30, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 1, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Saturday, new DateTime(1970, 1, 31, 0, 0, 0, DateTimeKind.Local));
        }

        private void December1970()
        {
            Add(1970, 12, Gregorian.WeekOfTheMonth.First, DayOfWeek.Sunday, new DateTime(1970, 12, 6, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.First, DayOfWeek.Monday, new DateTime(1970, 12, 7, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.First, DayOfWeek.Tuesday, new DateTime(1970, 12, 1, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.First, DayOfWeek.Wednesday, new DateTime(1970, 12, 2, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.First, DayOfWeek.Thursday, new DateTime(1970, 12, 3, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.First, DayOfWeek.Friday, new DateTime(1970, 12, 4, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.First, DayOfWeek.Saturday, new DateTime(1970, 12, 5, 0, 0, 0, DateTimeKind.Local));

            Add(1970, 12, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Sunday, new DateTime(1970, 12, 13, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Monday, new DateTime(1970, 12, 14, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Tuesday, new DateTime(1970, 12, 8, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Wednesday, new DateTime(1970, 12, 9, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Thursday, new DateTime(1970, 12, 10, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Friday, new DateTime(1970, 12, 11, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Saturday, new DateTime(1970, 12, 12, 0, 0, 0, DateTimeKind.Local));

            Add(1970, 12, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Sunday, new DateTime(1970, 12, 20, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Monday, new DateTime(1970, 12, 21, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Tuesday, new DateTime(1970, 12, 15, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Wednesday, new DateTime(1970, 12, 16, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Thursday, new DateTime(1970, 12, 17, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Friday, new DateTime(1970, 12, 18, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Saturday, new DateTime(1970, 12, 19, 0, 0, 0, DateTimeKind.Local));

            Add(1970, 12, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Sunday, new DateTime(1970, 12, 27, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Monday, new DateTime(1970, 12, 28, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Tuesday, new DateTime(1970, 12, 22, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Wednesday, new DateTime(1970, 12, 23, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Thursday, new DateTime(1970, 12, 24, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Friday, new DateTime(1970, 12, 25, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Saturday, new DateTime(1970, 12, 26, 0, 0, 0, DateTimeKind.Local));

            Add(1970, 12, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Sunday, new DateTime(1970, 12, 27, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Monday, new DateTime(1970, 12, 28, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Tuesday, new DateTime(1970, 12, 29, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Wednesday, new DateTime(1970, 12, 30, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Thursday, new DateTime(1970, 12, 31, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Friday, new DateTime(1970, 12, 25, 0, 0, 0, DateTimeKind.Local));
            Add(1970, 12, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Saturday, new DateTime(1970, 12, 26, 0, 0, 0, DateTimeKind.Local));
        }

        private void February1998()
        {
            Add(1998, 2, Gregorian.WeekOfTheMonth.First, DayOfWeek.Sunday, new DateTime(1998, 2, 1, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.First, DayOfWeek.Monday, new DateTime(1998, 2, 2, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.First, DayOfWeek.Tuesday, new DateTime(1998, 2, 3, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.First, DayOfWeek.Wednesday, new DateTime(1998, 2, 4, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.First, DayOfWeek.Thursday, new DateTime(1998, 2, 5, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.First, DayOfWeek.Friday, new DateTime(1998, 2, 6, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.First, DayOfWeek.Saturday, new DateTime(1998, 2, 7, 0, 0, 0, DateTimeKind.Local));

            Add(1998, 2, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Sunday, new DateTime(1998, 2, 8, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Monday, new DateTime(1998, 2, 9, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Tuesday, new DateTime(1998, 2, 10, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Wednesday, new DateTime(1998, 2, 11, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Thursday, new DateTime(1998, 2, 12, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Friday, new DateTime(1998, 2, 13, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Saturday, new DateTime(1998, 2, 14, 0, 0, 0, DateTimeKind.Local));

            Add(1998, 2, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Sunday, new DateTime(1998, 2, 15, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Monday, new DateTime(1998, 2, 16, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Tuesday, new DateTime(1998, 2, 17, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Wednesday, new DateTime(1998, 2, 18, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Thursday, new DateTime(1998, 2, 19, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Friday, new DateTime(1998, 2, 20, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Saturday, new DateTime(1998, 2, 21, 0, 0, 0, DateTimeKind.Local));

            Add(1998, 2, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Sunday, new DateTime(1998, 2, 22, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Monday, new DateTime(1998, 2, 23, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Tuesday, new DateTime(1998, 2, 24, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Wednesday, new DateTime(1998, 2, 25, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Thursday, new DateTime(1998, 2, 26, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Friday, new DateTime(1998, 2, 27, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Saturday, new DateTime(1998, 2, 28, 0, 0, 0, DateTimeKind.Local));

            Add(1998, 2, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Sunday, new DateTime(1998, 2, 22, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Monday, new DateTime(1998, 2, 23, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Tuesday, new DateTime(1998, 2, 24, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Wednesday, new DateTime(1998, 2, 25, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Thursday, new DateTime(1998, 2, 26, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Friday, new DateTime(1998, 2, 27, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 2, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Saturday, new DateTime(1998, 2, 28, 0, 0, 0, DateTimeKind.Local));
        }

        private void November1998()
        {
            Add(1998, 11, Gregorian.WeekOfTheMonth.First, DayOfWeek.Sunday, new DateTime(1998, 11, 1, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.First, DayOfWeek.Monday, new DateTime(1998, 11, 2, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.First, DayOfWeek.Tuesday, new DateTime(1998, 11, 3, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.First, DayOfWeek.Wednesday, new DateTime(1998, 11, 4, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.First, DayOfWeek.Thursday, new DateTime(1998, 11, 5, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.First, DayOfWeek.Friday, new DateTime(1998, 11, 6, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.First, DayOfWeek.Saturday, new DateTime(1998, 11, 7, 0, 0, 0, DateTimeKind.Local));

            Add(1998, 11, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Sunday, new DateTime(1998, 11, 8, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Monday, new DateTime(1998, 11, 9, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Tuesday, new DateTime(1998, 11, 10, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Wednesday, new DateTime(1998, 11, 11, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Thursday, new DateTime(1998, 11, 12, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Friday, new DateTime(1998, 11, 13, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Second, DayOfWeek.Saturday, new DateTime(1998, 11, 14, 0, 0, 0, DateTimeKind.Local));

            Add(1998, 11, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Sunday, new DateTime(1998, 11, 15, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Monday, new DateTime(1998, 11, 16, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Tuesday, new DateTime(1998, 11, 17, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Wednesday, new DateTime(1998, 11, 18, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Thursday, new DateTime(1998, 11, 19, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Friday, new DateTime(1998, 11, 20, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Third, DayOfWeek.Saturday, new DateTime(1998, 11, 21, 0, 0, 0, DateTimeKind.Local));

            Add(1998, 11, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Sunday, new DateTime(1998, 11, 22, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Monday, new DateTime(1998, 11, 23, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Tuesday, new DateTime(1998, 11, 24, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Wednesday, new DateTime(1998, 11, 25, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Thursday, new DateTime(1998, 11, 26, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Friday, new DateTime(1998, 11, 27, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Fourth, DayOfWeek.Saturday, new DateTime(1998, 11, 28, 0, 0, 0, DateTimeKind.Local));

            Add(1998, 11, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Sunday, new DateTime(1998, 11, 29, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Monday, new DateTime(1998, 11, 30, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Tuesday, new DateTime(1998, 11, 24, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Wednesday, new DateTime(1998, 11, 25, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Thursday, new DateTime(1998, 11, 26, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Friday, new DateTime(1998, 11, 27, 0, 0, 0, DateTimeKind.Local));
            Add(1998, 11, Gregorian.WeekOfTheMonth.Last, DayOfWeek.Saturday, new DateTime(1998, 11, 28, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
