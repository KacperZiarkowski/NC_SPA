using eShop_ApplicationCore.Model.Interface;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace eShop_ApplicationCore.Model.Employee
{
    public partial class Employee : Entity, IPerson
    {
        public Employee()
        {

        }

        public Employee(
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
                if (this._firstName != null && this._lastName != null)
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

    }
}
