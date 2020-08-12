using System;
using System.Collections.Generic;
using System.Text;
using eShop_ApplicationCore.Model.Abstract;

namespace eShop_ApplicationCore.Model.Customer
{
    public class Customer : Person
    {
        public Customer(
            string firstName,
            string lastName,
            string email,
            string phoneNumber
            )
        {
            base.FirstName = firstName;
            base.LastName = lastName;
            base.Email = email;
            base.PhoneNumber = phoneNumber;
        }

        public Adress {
            get;
            set;
        }



    }
}
