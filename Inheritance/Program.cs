using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //Student student = new Student();

            Person[] persons = new Person[3] 
            { 
                new Customer {Id=1, FirstName="Aysel", LastName="Mehmetzade", City="Marmaris" }, 
                new Student { Id = 1, FirstName = "Yusuf", LastName = "Demir", Department = "Psikoloji" } ,
                new Person {Id=2, FirstName="Engin", LastName="Demirog"}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);            
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

   
    class Customer : Person
    {
        public string City { get; set; }

    }
    class Student : Person
    {
        public string Department { get; set; }

    }
}
