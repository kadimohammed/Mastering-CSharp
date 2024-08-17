using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q__Interface
{
    internal class Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("The duck flies short distances.");
        }

        public void Swim()
        {
            Console.WriteLine("The duck swims in the pond.");
        }
    }
}
