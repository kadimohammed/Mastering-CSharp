using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    internal class Coppy
    {
        public int NumberCoppy { get; set; }
        public string NameFile { get; set; }

        public Coppy(int numberCoppy, string nameFile)
        {
            NumberCoppy = numberCoppy;
            NameFile = nameFile;
        }

        public void Print()
        {
            for(int i=0; i<NumberCoppy; i++)
            {
                Console.WriteLine($"printing {i + 1} -{NameFile}");
                Thread.Sleep(500);
            }
        }
    }
}
