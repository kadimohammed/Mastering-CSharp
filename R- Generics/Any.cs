using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R__Generics
{
    internal class Any<T>
        where T : struct      // T doit être un type référence (class)
        /*where T : class, new()      // T doit être un type référence (class) et doit avoir un constructeur sans paramètre
        where T : new()        // T doit avoir un constructeur sans paramètre
        where T : struct       // T doit être un type valeur (struct)
        where T : unmanaged    // T doit être un type non managé (comme int, float)
        where T : notnull      // T ne doit pas être nullable
        where T : System.Enum  // T doit être une énumération
        where T : System.Delegate // T doit être un délégué
        where T : IMyInterface       // T doit implémenter l'interface IMyInterface
        where T : IComparable<T>     // U doit implémenter l'interface IComparable<U>
        where T : MyBaseClass        // T doit hériter de MyBaseClass*/
    {
        private T[] Array;
        
        public void Add(T item)
        {
            if (Array is null)
            {
                this.Array = new T[] { item };
                return;
            }
            else
            {
                T[] NewArray = new T[Array.Length + 1];
                for (int i =0; i < Array.Length; i++)
                {
                    NewArray[i] = Array[i];
;               }
                NewArray[NewArray.Length - 1] = item;

                this.Array = NewArray;
            }
        }

        public override string ToString()
        {
            string s = "";
            if (Array is not null)
            {
                s += "{ ";
                for (int i = 0; i < Array.Length; i++)
                {
                    s+= i !=  Array.Length -1 ? Array[i] + " , " : Array[i];
                }
                s+= " }";
            }

            return s;
        }


        public bool IsEmpty => Array.Length == 0;

        public int Count => Array.Length;


    }

}
