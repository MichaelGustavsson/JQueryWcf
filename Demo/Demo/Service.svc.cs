using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    public class Service : IService
    {
        public IQueryable<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer {FirstName = "Kalle", LastName = "Anka"},
                new Customer {FirstName = "Bosse", LastName = "Kofot"}
            };
            return customers.AsQueryable();
        }
    }
}
