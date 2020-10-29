using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccessDemo
{
    // Data Model
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public int PhoneNumber { get; set; }
       
        public string fullInfo
        {
            get { return $"{Id} - {LastName} {FirstName} ({EmailAdress})"; }
        }

    }
}
