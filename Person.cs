using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDataAccessDemo
{
    public class Person
    {
        public int id { get; set; }
        public int FirstName{ get; set; }
        public int LastName { get; set; }
        public int EmailAddress { get; set; }
        public int PhoneNumber{ get; set; }

        public string FullInfo
        {
            get 
            { 
                return $"{ FirstName } { LastName } ({ EmailAddress })"; 
            }
        }

    }
}
