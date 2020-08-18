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
    class EmployeeGenerationIdentyficationTests
    {

        [Test]
        [TestCase("peter", "WaTts", "@ads", "6689", "PET-WAT-0")]
        [TestCase("Matt", "Po", "asd", "6689", "MAT-POO-0")]
        public void GenerateEmployeIdentificationBasedOnProperParametersInObjInitialization_returnsCorrectId(string firstName, string lastName, string email, string phone, string expectedResult)
        {
            var testEmploye1 = new eShop_ApplicationCore.Model.Employee.Employee(firstName, lastName, email, phone);

            var result = testEmploye1.EmployeeIdentifier;

            Assert.AreEqual(expectedResult, result);

        }
        [Test]
        [TestCase("peter", "WaTts", "@ads", "6689", "PET-WAT-0")]
        [TestCase("Matt", "Po", "asd", "6689", "MAT-POO-0")]
        public void GenerateEmployeManagerIdentificationBasedOnProperParametersInObjInitialization_returnsCorrectId(string firstName, string lastName, string email, string phone, string expectedResult)
        {
            var testEmploye1 = new EmployeeManager(firstName, lastName, email, phone);

            var result = testEmploye1.EmployeeIdentifier;

            Assert.AreEqual(expectedResult, result);

        }
    }
}
