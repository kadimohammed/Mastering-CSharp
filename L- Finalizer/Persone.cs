using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L__Finalizer
{
    internal class Persone
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Persone()
        {
            Console.WriteLine("Appel de constructor");
            Id = 1;
            Name = "ahmed";
        }

        ~Persone()
        {
            Console.WriteLine("Appel de destructor");
        }
    }
}
