using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZK__Records
{
    // hada struct record kaykhdem 3la value type machi reference type
    // kaykhazen f stack machi fl heap

    // override equals
    // override IEquatable<PointRecord>
    // override object GetHashCode
    // override == , !=
    // override ToString
    // deconstruct methode
    //constructor avec parametre7
    // les prop { get; set;}
    public record struct PointStructRecord(int X, int Y);



    // les prop { get; init;}
    //public readonly record struct PointStructRecord(int X, int Y);

    /*
    public readonly record struct PointStructRecord
    {
        // readonly record khas ga3 les prop ikono readonly ou te9det tzid ghi init

        public int X { get; init; } 
        public int Y { get; }
        public readonly int Z;
    }
    */
    
}