using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZG__Threading
{
    internal class Compte
    {
        public double Solde { get; set; } = 50;
        private static readonly object _lock = new object();


        public void Debit(double value)
        {
            lock (_lock)
            {
                if (Solde - value >= 0)
                {
                    Thread.Sleep(1000);
                    Solde -= value;
                }
            }
            
        }

        public void Credit(double value)
        {
            Thread.Sleep(1000);
            Solde += value;
        }

        public override string ToString()
        {
            return $"Solde : {Solde}";
        }
    }
}
