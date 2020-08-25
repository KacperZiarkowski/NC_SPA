﻿using eShop_ApplicationCore.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Employee
{
    public class EmployeeManager : Employee
    {
        public EmployeeManager()
        {
            
        }
        public EmployeeManager(
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
        public virtual ICollection<Employee> ManagerSubordinates { get; set; }
    }
}
