using kennel.Data;
using kennel.Factories;
using System;

namespace kennel.Customers
{
    internal class CustomerManager : ICustomerManager
    {
        public IDataRepository Db { get; set; }
        public CustomerManager(IDataRepository db)
        {
            Db = db;
        }
        public void RegisterCustomer()
        {
            ICustomer customer = CustomerFactory.Create();

            Console.WriteLine("Please enter customer ID number");
            customer.ID = Console.ReadLine();

            Console.WriteLine("Please enter customers First Name");
            customer.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter customers Last Name");
            customer.LastName = Console.ReadLine();

            Db.AddCustomer(customer);
        }

        public void ListCustomers()
        {
            var customers=Db.GetCustomers();
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
        }
    }
}