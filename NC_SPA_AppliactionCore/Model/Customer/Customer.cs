using System;
using System.Collections.Generic;
using System.Text;
using eShop_ApplicationCore.Model.Abstract;

namespace eShop_ApplicationCore.Model.Customer
{
    public class Customer : Entity, IPerson
    {
        private Customer()
        {
            // required by EF
        }

        public string CustomerId { get; private set; }
        public Address DeliveryAddress { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
    }
}
