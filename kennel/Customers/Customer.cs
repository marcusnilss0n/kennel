﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kennel.Customers
{
    public class Customer : ICustomer
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
    }
}
