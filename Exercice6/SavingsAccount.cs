using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    internal class SavingsAccount : BankAccount
    {
        double _interest;
        public SavingsAccount(Client client, double interest = 0.2) : base(client)
        {
            _interest = interest;
        }

        public void ApplyInterest()
        {
            _money += (decimal) _interest / 100 * _money;
        }

        public override string ToString()
        {
            return $"Savings account: Interest = {_interest} " + base.ToString();
        }
    }
}
