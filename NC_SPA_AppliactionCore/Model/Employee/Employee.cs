using eShop_ApplicationCore.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Employee
{
     public class Employee : Person
    {
        public Employee()
        {
            
        }
        public Employee(string firstName, string lastName, string email,string phoneNumber)
        {
            base.FirstName = firstName;
            base.LastName = lastName;
            base.Email = email;
            base.PhoneNumber = phoneNumber;
           
        }

        //private Employee()
        //{
        //    // required by EF
        //}

        public string EmployeeId { get; set; }

    }
}
