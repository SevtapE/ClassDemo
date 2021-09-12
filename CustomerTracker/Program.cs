using System;
using System.Collections.Generic;

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

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Sammy";
            customer2.LastName = "Williams";
            customer2.PhoneNumber = " 222222222";


            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Ashley";
            customer3.LastName = "Hill";
            customer3.PhoneNumber = " 111111111";
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Delete(customer2);
            List<Customer> customers=customerManager.List();
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Customer Id: {customer.Id,-3} Name: {customer.FirstName,-9} Lastname: {customer.LastName,-9} Phone Number: {customer.PhoneNumber}");
            }
        }
    }
}
