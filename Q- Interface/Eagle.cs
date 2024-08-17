using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q__Interface
{
    internal class Eagle : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("The eagle soars high in the sky.");
        }
    }
}
