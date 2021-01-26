using System;

namespace Classes
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

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Aysel";
            customer1.LastName = "Mehmetzade";
            customer1.City = "Marmaris";

            Customer customer2 = new Customer {Id=2,FirstName="Yusuf", LastName="Demir", City="İstanbul" };

            Console.WriteLine(customer1.FirstName +" "+ customer2.FirstName);

            Console.ReadLine();
        }
    }
   
    
}
