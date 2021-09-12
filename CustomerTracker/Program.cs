using System;

namespace CustomerTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Josh";
            customer1.LastName = "Johnson";
            customer1.PhoneNumber = " 9999999999";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
        }
    }
}
