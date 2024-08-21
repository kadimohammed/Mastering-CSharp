using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U__Enumerators_Iterators
{
    internal class Temperature : IComparable
    {
        public int value { get; set; }
        public Temperature()
        {
            value = 0;
        }

        public int CompareTo(object? obj)
        {
            if (obj is null)
            {
                return 1;
            }
            Temperature p = obj as Temperature;
            if (p != null)
            {
                return p.value.CompareTo(value);
            }
            else
                throw new ArgumentException("object is not temperature");
        }

    }
}
