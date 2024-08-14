using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Events
{
    public class Cafetiere
    {
        public delegate void MyDeleg(MyCustomEventArgs a);

        //public MyDeleg func;

        public event EventHandler<MyCustomEventArgs> CafePret;

        public int id = 1000;

        public void PreparerCafe()
        {
            Console.WriteLine("Le café se prépare...");
            System.Threading.Thread.Sleep(3000);

            MyCustomEventArgs ca = new MyCustomEventArgs("hello", 12);
            //func(ca);

            CafePret?.Invoke(this, ca);
            //CafePret(this, ca);
        }

    }
}
