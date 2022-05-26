using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Adana";
            customer.Id = 1;
            customer.FirstName = "İkbal";
            customer.LastName = "Kolay";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName="Samet",
                LastName="Ramazan",
                City="Ankara" 
            };

            Console.WriteLine(customer2.FirstName);


            Console.ReadLine();
        }

    }
}
