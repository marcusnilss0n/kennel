using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kennel.Animals;
using kennel.Customers;
using kennel.Data;

namespace kennel.Data
{
    
    public class DataRepository : IDataRepository
    {
        public IDatabaseUsingLists Db { get; set; }        

        public DataRepository(IDatabaseUsingLists db)
        {
            Db = db;
        }

        // Customers
        public ICustomer GetCustomerByID(string customerId) => Db.Customers.Where(r => r.ID == customerId).FirstOrDefault();

        public List<ICustomer> GetCustomers()
        {
            return Db.Customers;
        }

        public void AddCustomer(ICustomer customer)
        {
            Db.Customers.Add(customer);
        }

        // Animals
        public IAnimal GetAnimalByID(string animalId)
        {
            return Db.Animals.Where(animal => animal.ID == animalId).FirstOrDefault();
        }

        public List<IAnimal> GetAnimals()
        {
            return Db.Animals;
        }

        public void AddAnimal(IAnimal animal)
        {
            Db.Animals.Add(animal);
        }

        public IAnimal GetAnimal(string animalPicker)
        {
            return Db.Animals.Where(animal => animal.Name == animalPicker).FirstOrDefault();
        }
    }
}
