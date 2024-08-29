using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZK__Records
{
    // override equals
    // override IEquatable<PointRecord>
    // override object GetHashCode
    // override == , !=
    // override ToString
    // deconstruct methode
    //constructor avec parametre7
    // les prop { get; init;}
    public record PointRec(int X, int Y);

    // ila bghit tzid constructeur par defaut 3la record positionale
    /*
    public record PointRec(int X, int Y)
    {
        public PointRec() : this(0,0)
        {
            
        }
    }
    */
}
