using kennel.Animals;
using kennel.Customers;
using System.Collections.Generic;

namespace kennel.Data
{
    interface IDataRepository
    {
        IDatabaseUsingLists Db { get; set; }

        List<ICustomer> GetCustomers();
        void AddCustomer(ICustomer customer);

        List<IAnimal> GetAnimals();
        void AddAnimal(IAnimal animal);
        IAnimal GetAnimal(string animalPicker);
    }
}