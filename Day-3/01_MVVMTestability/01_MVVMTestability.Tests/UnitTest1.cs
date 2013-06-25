using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01_MVVMTestability.ViewModels;

namespace _01_MVVMTestability.Tests
{
    [TestClass]
    public class EmployeeViewModelTests
    {
        [TestMethod]
        public void When_FirstName_IsEmpty_CanFullNameBeGeneratedReturnsFalse()
        {
           //Arrange
            var sut = new Employee();

            //Act
            sut.FirstName = string.Empty;

            //Assert
            Assert.IsFalse(sut.CanFullNameBeGenerated);
        }
    }
}
