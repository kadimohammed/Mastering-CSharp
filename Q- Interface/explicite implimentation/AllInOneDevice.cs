using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q__Interface.explicite_implimentation
{
    internal class AllInOneDevice : IPrinter, IScanner
    {
        public int prop
        {
            get
            {
                Console.WriteLine("get AllInOneDevice");
                return 0;
            }
            set
            {
                Console.WriteLine("set AllInOneDevice");
                value = 6;
            }
        }


        // Explicit implementation of IPrinter.Print
        void IPrinter.Print()
        {
            Console.WriteLine("Printing from the printer...");
        }

        // Explicit implementation of IScanner.Print
        void IScanner.Print()
        {
            Console.WriteLine("Printing from the scanner...");
        }

        // You can also have a method with the same name in the class itself
        public void Print()
        {
            Console.WriteLine("Printing from the all-in-one device...");
        }

        public void M()
        {
            Console.WriteLine("M implimentation");
        }

        public void Display()
        {
            Console.WriteLine("display for AllInOneDevice");
        }
    }
}
