using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZK__Records
{
    internal struct MyPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; init; } // hadi katkhalik tinitializer une seul fois ghi f object initializer

        public MyPoint(int x, int y)
        {
            X = x;
            Y = y;
            Z = 0;
        }

        public override string ToString()
        {
            return $"{{X={X}  Y={Y}  Z={Z}}}";
        }
    }
}
