using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonManager personManager = new PersonManager();
            //personManager.Add(new Customer { Id = 1, FirstName = "Aysel", LastName = "Mehmetzade", Address = "Marmaris" });

            //Student student = new Student { Id = 1, FirstName = "Yusuf", LastName = "Demir", Departmant = "Psikoloji" };
            //personManager.Add(student);

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[3] { new SqlServerCustomerDal(), new OracleCustomerDal(), new MysqlCustomerDal() };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }

    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
