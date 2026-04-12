using System;
using System.Threading.Tasks;
using TensionDev.Calendar;
using Xunit;

namespace TensionDev.Calendar.Tests
{
    public class GregorianTests : IDisposable
    {
        private bool disposedValue;

        [Theory]
        [ClassData(typeof(FirstDayOfTheMonthTestData))]
        public void TestFirstDayOfTheMonth(DateTime value, DateTime expected)
        {
            DateTime actual = Gregorian.FirstDayOfTheMonth(value);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(FirstDayOfTheMonthUtcTestData))]
        public void TestFirstDayOfTheMonthUtc(DateTime value, DateTime expected)
        {
            DateTime actual = Gregorian.FirstDayOfTheMonthUtc(value);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(LastDayOfTheMonthTestData))]
        public void TestLastDayOfTheMonth(DateTime value, DateTime expected)
        {
            DateTime actual = Gregorian.LastDayOfTheMonth(value);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(LastDayOfTheMonthUtcTestData))]
        public void TestLastDayOfTheMonthUtc(DateTime value, DateTime expected)
        {
            DateTime actual = Gregorian.LastDayOfTheMonthUtc(value);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(DayOfTheMonthTestData))]
        public void TestGetDayOfTheMonth(int year, int month, Gregorian.WeekOfTheMonth weekOfTheMonth, DayOfWeek dayOfWeek, DateTime expected)
        {
            DateTime actual = Gregorian.GetDayOfTheMonth(year, month, weekOfTheMonth, dayOfWeek);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(DayOfTheMonthUtcTestData))]
        public void TestGetDayOfTheMonthUtc(int year, int month, Gregorian.WeekOfTheMonth weekOfTheMonth, DayOfWeek dayOfWeek, DateTime expected)
        {
            DateTime actual = Gregorian.GetDayOfTheMonthUtc(year, month, weekOfTheMonth, dayOfWeek);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(NextWeeksDayOfTheWeekTestData))]
        public void TestNextWeeksDayOfTheWeek(DateTime value, DayOfWeek dayOfWeek, DateTime expected)
        {
            DateTime actual = Gregorian.GetNextWeeksDayOfTheWeek(value, dayOfWeek);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(PreviousWeeksDayOfTheWeekTestData))]
        public void TestPreviousWeeksDayOfTheWeek(DateTime value, DayOfWeek dayOfWeek, DateTime expected)
        {
            DateTime actual = Gregorian.GetPreviousWeeksDayOfTheWeek(value, dayOfWeek);

            Assert.Equal(expected, actual);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UnitTestGregorian()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}