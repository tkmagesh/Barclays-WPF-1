using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01_MVVMTestability.Domain;

namespace _01_MVVMTestability.Tests
{
    public class FakeTimeServiceReturningMorningTime : ITimeService
    {
        public DateTime GetCurrentDateTime()
        {
            return new DateTime(2013,06,26,9,0,0);
        }
    }

    public class FakeTimeServiceReturningAfternoonTime : ITimeService
    {
        public DateTime GetCurrentDateTime()
        {
            return new DateTime(2013, 06, 26, 21, 0, 0);
        }
    }

    [TestClass]
    public class GreeterTests
    {
        [TestMethod]
        public void When_Greeted_Before_12_Greets_GoodMorning()
        {
            //Arrange
            var timeServiceForMorning = new FakeTimeServiceReturningMorningTime();
            var greeter = new Greeter(timeServiceForMorning);
            var name = "Magesh";

            //Act
            var greetMsg = greeter.Greet(name);

            //Assert
            Assert.IsTrue(greetMsg.Contains("Good Morning"));
        }
        [TestMethod]
        public void When_Greeted_After_12_Greets_GoodAfternoon()
        {
            //Arrange
            var timeServiceForAfternoon = new FakeTimeServiceReturningAfternoonTime();
            var greeter = new Greeter(timeServiceForAfternoon);
            var name = "Magesh";

            //Act
            var greetMsg = greeter.Greet(name);

            //Assert
            Assert.IsTrue(greetMsg.Contains("Good Afternoon"));
        }
    }
}
