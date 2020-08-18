using eShop_ApplicationCore.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace eShop_ApplicationCore.Model.Employee
{
    public class Employee : Entity, IPerson
    {
        public Employee()
        {
                
        }

        public  Employee(
            string firstName,
            string lastName,
            string email,
            string phoneNumber
            )
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            GenerateIdentification(this.FirstName, this.LastName);
        }

        private string _firstName;
       
        private string _lastName;


        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string EmployeeIdentifier { get; set; }

        public string FirstName
        {
            get => this._firstName;
            set
            {
                _firstName = value;
                if (this._firstName != null && this._lastName!= null)
                {
                    GenerateIdentification(this._firstName, this._lastName);
                }
                
            }
        }

        public string LastName
        {
            get => this._lastName;
            set
            {
                this._lastName = value;
                if (this._firstName != null && this._lastName != null)
                {
                    GenerateIdentification(this._firstName, this._lastName);
                }
            }
        }

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
