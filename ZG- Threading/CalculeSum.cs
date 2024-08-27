using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZG__Threading
{
    public class CalculeSum
    {
        public int[] Tab { get; set; }
        public int Somme { get; set; }


        public void ClaculeSum(int Debut, int Fin)
        {
            for (int i = Debut; i < Fin; i++)
            {
                Somme += Tab[i];
            }
        }




    }
}
