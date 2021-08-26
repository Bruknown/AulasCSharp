using System;
using System.Collections.Generic;
using System.Text;

namespace AulaExecicio1.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double quantia)
        {
            Balance -= quantia;
        }

        public void Deposit(double quantia)
        {
            Balance += quantia;
        }

    }
}
