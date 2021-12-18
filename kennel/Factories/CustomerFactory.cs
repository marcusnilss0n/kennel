using kennel.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kennel.Factories
{
    public static class CustomerFactory
    {
        public static ICustomer Create()
        {
            return new Customer();
        }
    }
}
