using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T__Exceptions
{
    internal class MyException : Exception
    {
        public string Location { get; set; }
        public MyException(string location, string s) : base(s) 
        { 
            this.Location = location;
        }
    }
}
