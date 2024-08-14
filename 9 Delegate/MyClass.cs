using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Delegate
{
    internal class MyClass
    {
        public delegate int MyClassDelegate(int a, int b);

        MyClassDelegate addDelegate = new MyClassDelegate((h, j) =>
        {
            return h + j;
        });

        MyClassDelegate addDelegate1 = (h, j) =>
        {
            return h + j;
        };

        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static void Somme(MyClassDelegate A)
        {
            int q = A(4, 5);
            Console.WriteLine(q);
        }


    }
}
