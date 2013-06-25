using System;

namespace _01_MVVMTestability.Domain
{
    public class TimeService : ITimeService
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
    }
}