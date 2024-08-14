using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _9_Delegate
{
    public class FilterNumbers
    {
        public delegate  bool FilterCriteria(int a);

        public IList<int> FiltrerNumbers(IList<int> numbers, FilterCriteria deleg)
        {
            IList<int> NewNumbers = new List<int>();
            foreach (var n in numbers)
            {
                if (deleg(n))
                {
                    NewNumbers.Add(n);
                }
            }

            return NewNumbers;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsOdd(int number)
        {
            return number % 2 != 0;
        }


        public bool IsGreaterThanTen(int number)
        {
            return number > 10;
        }
    }
}
