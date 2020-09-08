using System;
using System.ComponentModel.DataAnnotations;
using eShop_ApplicationCore.Model.Interfaces;

namespace eShop_ApplicationCore.Model.Customer
{
    public class Customer : Entity, IPerson
    {
        
        public Guid CustomerGuid { get; private set; }

        public Address DeliveryAddress { get; private set; }
       
        [Required(ErrorMessage = "First Name Is Required")]
        public string FirstName { get; private set; }

        [Required(ErrorMessage = "Last Name Is Required")]
        public string LastName { get; private set; }

        [Required(ErrorMessage = "Email Is Required")]
        public string Email { get; private set; }

        public string PhoneNumber { get; private set; }

    }
}
