using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using eShop_ApplicationCore.Model.Abstract;
using eShop_ApplicationCore.Model.Employee;
using NUnit.Framework;

namespace UnitTests.ApplicationCore_Tests.Model.Employee
{
    [TestFixture]
    class EmployeeGenerationIdentyficationTestss
    {
        private readonly eShop_ApplicationCore.Model.Employee.Employee
            _testEmployee = new eShop_ApplicationCore.Model.Employee.Employee
            {
                Email = "test@test.com",
                FirstName = "Tom",
                LastName = "Buum",
                PhoneNumber = "758968758"
            };


        [Test]
        public void GenerateEmployeIdentificationBasedOnProperValues_returnsCorrectId()
        {
            var test = _testEmployee;
            var result = Person.GeneratePersonIdentification(test);
                
            Assert.AreEqual("TOM-BUU-0", result);

        }

        [TestCase("Si","Ma")]
        [TestCase("Peter","Watts")]
        public void GenerateEmployeIdentificationBasedNotProper_returnsCorrectId(string firstName, string lastName)
        {
            var test = new eShop_ApplicationCore.Model.Employee.Employee
            {
                 FirstName = firstName,
                 LastName = lastName
            };
            
            var result = eShop_ApplicationCore.Model.Employee.Employee.GenerateIdentification(test);
            
            Assert.AreEqual("PET-WAT-0", result);
            Assert.AreEqual("SII-MAA-1", result);
        }

    }
}
