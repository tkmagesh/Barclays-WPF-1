using System;
using System.ComponentModel.Composition;

namespace _01_MVVMTestability.Domain
{
    [Export(typeof(ITimeService))]
    public class TimeService : ITimeService
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
    }
}