using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Employee
{
    
    public partial class Employee
    {

        public void GenerateIdentification(string firstName, string lastName)
        {
            if (lastName.Length <= 2)
            {
                var lastCharacter = lastName.Substring(lastName.Length - 1);
                lastName += lastCharacter;
            }

            if (firstName.Length <= 2)
            {
                var lastCharacter = firstName.Substring(firstName.Length - 1);
                firstName += lastCharacter;

            }
            var resultedIdentifier = (firstName.Substring(0, 3) + "-" + lastName.Substring(0, 3) + "-" + this.Id).ToUpper();
            this.EmployeeIdentifier = resultedIdentifier;
        }
    }
}
