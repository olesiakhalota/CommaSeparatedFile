using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommaSeparatedFile
{
    public class Person // internal - binnen hetzelf project. public - class library
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }

        public override string ToString()
        {
            return $"{FirstName}, {LastName}, {Adress}";
        }


    }
}
