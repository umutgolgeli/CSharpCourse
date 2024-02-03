using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
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
            customer.FirstName = "Umut"; ;
            customer.LastName = "Gölgeli";
            customer.Id = 1;
            customer.City = "Ankara";
            Console.WriteLine(customer);

            Customer customer2 = new Customer
            {
                FirstName = "Lale",
                LastName = "Gölgeli",
                Id = 2,
                City = "Ankara"
            };
            Console.WriteLine(customer2.FirstName);
            

            Console.ReadLine();

        }
    }

  

   
}
