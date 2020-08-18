using System;
using System.Collections.Generic;
using System.Text;
using eShop_ApplicationCore.Model.Abstract;

namespace eShop_ApplicationCore.Model.Customer
{
    public class Customer : IPerson
    {
        public Address DeliveryAddress { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
