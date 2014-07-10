using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Person
    {
        private DateTime birthday;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime Birthday
        {
            get;
            set
            {
                if (value >= new DateTime(1900, 1, 1) && value <= new DateTime(2014, 12, 31))
                {
                    birthday = value;
                }
            }
        }
    }
}
