using kennel.Animals;
using kennel.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kennel.Data
{
    public class DatabaseUsingLists : IDatabaseUsingLists
    {
        public List<ICustomer> Customers { get; set; }

        public List<IAnimal> Animals { get; set; }        

        public DatabaseUsingLists()
        {
            Customers = new();
            Animals = new();
        }
    }
}
