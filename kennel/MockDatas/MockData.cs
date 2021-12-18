using Bogus;
using kennel.Customers;
using kennel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kennel.MockDatas
{
    public class MockData : IMockData
    {
        public IDatabaseUsingLists Db { get; set; }
        public MockData(IDatabaseUsingLists databaseUsingList)
        {
            Db = databaseUsingList;
        }
        public void GenerateCustomer()
        {
            // Create Customer
            for (int i = 1; i < 10; i++)
            {
                var customer = new Customer
                {
                    FirstName = new Faker().Name.FirstName(),
                    LastName = new Faker().Name.LastName()
                };

                Db.Customers.Add(customer);
            }
        }
    }

}
