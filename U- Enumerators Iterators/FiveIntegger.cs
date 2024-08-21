using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U__Enumerators_Iterators
{
    internal class FiveIntegger : IEnumerable
    {
        public int[] List { get; set; } = { 1, 2, 3, 4, 5 };

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(this);
            /*
            foreach(var item in List)
            {
                yield return item;
            }*/
        }
    }


    class MyEnumerator : IEnumerator
    {
        private int currentIndex = -1;
        private FiveIntegger fiveIntegger;

        public MyEnumerator(FiveIntegger fiveIntegger)
        {
            this.fiveIntegger = fiveIntegger;
        }

        public object Current {
            get
            {
                if (currentIndex >= this.fiveIntegger.List.Length)
                    throw new IndexOutOfRangeException();
                return this.fiveIntegger.List[currentIndex];
            }
        }

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < this.fiveIntegger.List.Length;
        }

        public void Reset()
        {
            currentIndex = -1 ;
        }
    }
}
