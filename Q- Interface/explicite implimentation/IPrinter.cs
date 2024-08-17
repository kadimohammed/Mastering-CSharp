using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q__Interface.explicite_implimentation
{
    internal interface IPrinter
    {
        public int prop
        {
            get
            {
                Console.WriteLine("get IPrinter");
                return 0;
            }
            set
            {
                Console.WriteLine("set IPrinter");
                value = 6;
            }
        }

        public void Display()
        {
            Console.WriteLine("display for Printer");
        }

        abstract void M();

        void Print();
    }
}
