using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Enums
{
    enum MonthEnum : int // par defaut il est int
    {
        January = 1, //par defaut il est egale 0
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    
    enum MonthEnum1
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
        MyMonths = January | February | March 
    }

    /*[Flags]
    enum MonthEnum1
    {
        January   = 0b_0000_0001,        // 1
        February  = 0b_0000_0010,        // 2
        March     = 0b_0000_0100,        // 4
        April     = 0b_0000_1000,        // 8
        May       = 0b_0001_0000,        // 16
        June      = 0b_0010_0000,        // 32
        July      = 0b_0100_0000,        // 64
        August    = 0b_1000_0000,        // 128
        September = 0b_1_0000_0000,      // 256
        October   = 0b_10_0000_0000,     // 512
        November  = 0b_100_0000_0000,    // 1024
        December  = 0b_1_0000_0000_0000, // 2048
        MyMonths  = January | February | March // 0b_0000_0111
    }*/
}
