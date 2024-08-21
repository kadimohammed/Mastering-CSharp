using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W__Extension_Methods
{
    public class Pizza
    {
        public string Content { get; set; }
        public double Prix { get; set; }


        //methoode d'instance dima kateghleb methode d'extension
        public Pizza AddSauce(string c)
        {
            Console.WriteLine("methode dinstance");
            this.Content += "\n" + c;
            this.Prix += 40;
            return this;
        }


        public override string ToString()
        {
            return $"{Content}\n...................\n{Prix}";
        }
    }
}
