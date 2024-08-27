using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZG__Threading
{
    internal class Transfere
    {
        private Compte compte1;
        private Compte compte2;
        private double amount;

        public Transfere(Compte cmp1, Compte cmp2, double amount)
        {
            this.compte1 = cmp1;
            this.compte2 = cmp2;
            this.amount = amount;
        }


        public void Envoyer()
        {
            lock (compte1)
            {
                Thread.Sleep(1000);
                /*lock (compte2)
                {
                    compte1.Debit(amount);
                    compte2.Credit(amount);
                }*/

                if (Monitor.TryEnter(compte2,3000))
                {
                    try
                    {
                        compte1.Debit(amount);
                        compte2.Credit(amount);
                        Console.WriteLine("transfere Bien Efectuer.");
                    }
                    catch
                    {
                        Console.WriteLine("eroor");
                    }
                    finally
                    {
                        Monitor.Exit(compte2);
                    }
                    
                }
                else
                {
                    Console.WriteLine("transfere impossible !!!");
                }
                //Thread.Sleep(3000);
            }
        }
    }
}
