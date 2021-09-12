using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTracker
{
    class CustomerManager
    {
        List<Customer> _customers;
        public void Add(Customer customer)
        {

            Console.WriteLine("{0} is added.",customer.FirstName);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("{0} is deleted.", customer.FirstName);
        }
        public List<Customer> List()
        {
            return _customers;

        }
    }
}
