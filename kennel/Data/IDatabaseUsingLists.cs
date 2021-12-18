using kennel.Animals;
using kennel.Customers;
using System.Collections.Generic;

namespace kennel.Data
{
    public interface IDatabaseUsingLists
    {
       public List<IAnimal> Animals { get; set; }
       public List<ICustomer> Customers { get; set; }
    }
}