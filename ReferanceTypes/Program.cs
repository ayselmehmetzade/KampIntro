using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("Sayi 1: " + sayi1);

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("Sayılar 1in 0.elemanı "+sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirsName = "Engin";
            person2 = person1;
            person1.FirsName = "Derin";

            Console.WriteLine(person2.FirsName);


            Custumer custumer = new Custumer();
            custumer.FirsName = "Salih";
            custumer.CreditCardNumber = "123456789";
            Employee employee = new Employee();
            employee.FirsName = "Aysel";

            Person person3 = custumer;
            custumer.FirsName = "Ahmet";

            Console.WriteLine(person3.FirsName);
            Console.WriteLine(((Custumer)person3).CreditCardNumber);
            Console.WriteLine("---------------------------------------");

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(custumer);
            personManager.Add(employee);


        }
    }
    //base class=Person
    class Person
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }

    }

    class Custumer: Person
    {
        public string CreditCardNumber { get; set; }

    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }

    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirsName);
        }
    }
}
