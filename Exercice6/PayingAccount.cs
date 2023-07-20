using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    internal class PayingAccount : BankAccount
    {
        public PayingAccount(Client client) : base(client)
        {
            
        }

        public override string ToString()
        {
            return "Paying account: " + base.ToString();
        }
    }
}
