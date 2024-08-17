using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q__Interface
{
    internal class Fish : ISwimmable
    {
        public void Swim()
        {
            Console.WriteLine("The fish swims in the ocean.");
        }
    }
}
