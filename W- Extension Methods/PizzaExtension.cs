using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W__Extension_Methods
{
    public static class PizzaExtension
    {
        public static Pizza AddOlive(this Pizza p , string type)
        {
            p.Content += "\n"+ type;
            p.Prix += 20;
            return p;
        }

        public static Pizza AddChecken(this Pizza p, string c)
        {
            p.Content += "\n" + c;
            p.Prix += 40;
            return p;
        }

        public static Pizza AddSauce(this Pizza p, string c)
        {
            p.Content += "\n" + c;
            p.Prix += 40;
            return p;
        }
    }
}
