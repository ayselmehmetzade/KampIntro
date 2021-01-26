using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }
        //private string _firstName;
        //public string FirstName { get { return "Sayın "+ _firstName; } set { _firstName = value; } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
