﻿using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace _01_MVVMTestability.Domain
{
    [Export]
    public class Greeter
    {
        private readonly ITimeService _timeService;

        [ImportingConstructor]
        public Greeter([Import]ITimeService timeService)
        {
            _timeService = timeService;
        }

        public string Greet(string name)
        {
            if (_timeService.GetCurrentDateTime().Hour < 12)
                return string.Format("Hi {0}, Good Morning",name);
            return string.Format("Hi {0}, Good Afternoon",name);
        }
    }
}
