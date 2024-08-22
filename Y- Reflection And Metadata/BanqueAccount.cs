using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y__Reflection_And_Metadata
{
    public class BanqueAccount
    {
        private string _name;
        private long _number;
        private double _balance;


        public string Name => _name;
        public long Number => _number;
        public double Balance => _balance;

        public delegate void BanqueAccountDelegateHandler(BanqueAccount obj, double newBalance);

        public event BanqueAccountDelegateHandler MyEvent;

        public BanqueAccount(string name, long number, double balance)
        {
            _name = name;
            _number = number;
            _balance = balance;
        }

        public BanqueAccount()
        {
        }


        public override string ToString()
        {
            return $"{_number} - {_name} - {_balance}";
        }


        public void Deposit(double value)
        {
            this._balance += value;
        }


        public void Withdraw(double value)
        {
            this._balance -= value;
            if (_balance < 0)
            {
                MyEvent?.Invoke(this, this._balance);
            }
        }


    }
}
