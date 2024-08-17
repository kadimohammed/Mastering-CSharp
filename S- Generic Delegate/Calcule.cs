using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static genericDelegate.Program;

namespace S__Generic_Delegate
{
    internal class Calcule<T>
    {
       public void Calculer(IEnumerable<T> list, Filter<T> filter)
        {
            foreach (T i in list)
            {
                if (filter(i))
                {
                    Console.Write(i + " ");
                }
            }

        }

        public void Calculer1(IEnumerable<T> list, Predicate<T> filter, Action<T> Printer)
        {
            foreach (T i in list)
            {
                if (filter(i))
                {
                    Printer(i);
                }
            }

        }
    }
}
