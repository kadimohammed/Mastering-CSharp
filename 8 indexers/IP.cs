using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_indexers
{
    internal class IP
    {
        private int[] segmentIP = new int[4];
        private int[,] tab = new int[4, 4];

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= tab.GetLength(0))
                    throw new ArgumentException("out of range");
                return segmentIP[index];
            }
            set
            {
                segmentIP[index] = value;
            }
        }

        public int this[int index1, int index2]
        {
            get
            {
                if (index1 < 0 || index1 >= tab.GetLength(0) || index2 < 0 || index2 >= tab.GetLength(1))
                    throw new ArgumentException("out of range");
                return tab[index1, index2];
            }
            set
            {
                if (value < 0 || value >= tab.GetLength(0) || value < 0 || value >= tab.GetLength(1))
                    return;
                tab[index1, index2] = value;
            }
        }

        public IP(int a, int b, int c, int d)
        {
            segmentIP[0] = a;
            segmentIP[1] = b;
            segmentIP[2] = c;
            segmentIP[3] = d;
        }

        public string GetIP => string.Join(".", segmentIP);
    }
}
