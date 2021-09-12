using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTracker
{
    class CustomerManager
    {
        List<Customer> _customers = new List<Customer>();
        public void Add(Customer customer)
        {
            _customers.Add(customer);
            Console.WriteLine("{0} is added.",customer.FirstName);
        }
        public void Delete(Customer customer)
        {
            Customer customerToRemove = customer;
            _customers.Remove(customerToRemove);
            Console.WriteLine("{0} is deleted.", customer.FirstName);
        }
        public List<Customer> List()
        {
            return _customers;

        }
    }
}
