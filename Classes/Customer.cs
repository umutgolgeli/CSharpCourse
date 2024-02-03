using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, City: {City}";
        }
    }
}
