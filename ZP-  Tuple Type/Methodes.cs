using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZP___Tuple_Type
{
    internal class Methodes
    {
        public static void GetNameAndLocation(out string name ,out double lattitude,out double longitude)
        {
            name = "Figuig";
            lattitude = 34.55555;
            longitude = -1.24866322;
        }


        public static Tuple<string,double,double> GetNameAndLocationV2()
        {
            //return new Tuple<string, double, double>("Figuig", 34.55555, 34.55555);
            return Tuple.Create("Figuig", 34.55555, -1.25452);
        }

        public static ValueTuple<string, double, double> GetNameAndLocationV3()
        {
            return ValueTuple.Create("Figuig", 34.55555, -1.25452);
        }




        // value tuple Implicit Names kaymtaz had tari9a aktar redability
        public static (string, double, double) GetNameAndLocationV4()
        {
            return ValueTuple.Create("Figuig", 34.55555, -1.25452);
        }

        // value tuple Implicit Names kaymtaz had tari9a aktar redability
        public static (string, double, double) GetNameAndLocationV5()
        {
            return ("Figuig", 34.55555, -1.25452);
        }


        // value tuple Explicit Names kaymtaz had tari9a aktar redability
        public static (string name, double lat, double lon) GetNameAndLocationV7()
        {
            return ("Figuig", 34.55555, -1.25452);
        }
    }
}
