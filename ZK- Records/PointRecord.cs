using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZK__Records
{
    // record de type class par defaut 
    record class PointRecord // reference type record
    {
        // override equals
        // override IEquatable<PointRecord>
        // override object GetHashCode
        // override == , !=
        // override ToString
        public int X;
        public int Y;

        public PointRecord(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Deconstruct(out int x, out int y)
        {
            x = X;
            y = Y;
        }
    }
}
