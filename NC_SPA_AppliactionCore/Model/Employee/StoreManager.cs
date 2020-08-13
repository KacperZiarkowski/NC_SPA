using eShop_ApplicationCore.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop_ApplicationCore.Model.Employee
{
    public class StoreManager : Person
    {
        public virtual ICollection<Employee> Subordinates { get; set; }
    }
}
